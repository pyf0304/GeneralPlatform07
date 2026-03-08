using com.taishsoft.common;
using com.taishsoft.syspara;
using Comm.WebApi;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Entity;
using GpWA.PubFun;
using GpWAT3.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SpecData;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace SimplePrjWA1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            ConfigHelper._Init(configuration); //配置ConfigHelper
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSession();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".GpWA.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(30);
                options.Cookie.IsEssential = true;
            });

            services.AddRazorPages();
            services.AddControllers();
            //services.AddControllers(options =>
            //{
            //    options.Filters.Add(typeof(ApiAuthorizeAttributeV3));
            //});

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                builder =>
                {
                    builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });
            try
            {
                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "GpWA", Version = "v1" });
                    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                    {
                        Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
                        Name = "Authorization",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.Http,
                        Scheme = "bearer",
                        BearerFormat = "JWT"
                    });
                    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
                });
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
            }
            clsDebugBase_Sql.IsDebug = true;
            clsDebugBase_Sql.LogDir4Debug = @"D:\Log\GpWA\";
            clsDebugBase_Sql.LogFile4Debug = "Log4DataBase";
            clsDebugBase_Sql.TraceLevel = 4;
            clsDebugBase_Pub.TraceLevel = 4;
            clsPubVar4BLEx.objLog = new clsLog(@"D:\Log\GpWA\", "Debug4BLEx");
            clsSysParaEN.objErrorLog = new clsLog(@"D:\Log\GpWA\", "errorMsg");
            clsSysParaEN.objLog = new clsLog(@"D:\Log\GpWA\", "Debug4SysPara");
            clsPubVar_WebApi.objLog = new clsLog(@"D:\Log\GpWA\", @"Log4Dubug_WebApi");

            com.taishsoft.commdb.clsSpecSQLforSql.IsUseEncrypt = false;
            com.taishsoft.commdb.clsSpecSQLforSql.AppType = "NetCoreWebApi";

            Console.WriteLine($"ConnectionString = {Configuration["ConnectionString"]}");
            Console.WriteLine($"providerName = {Configuration["providerName"]}");
            clsSpecSQL.strConnectString = Configuration["ConnectionString"];

            clsPubFun4BLEx.SetCommFun4BL();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseSession();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GPWA v1"));
                app.UseSwaggerUI();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("AllowAll");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                      name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //--------------
            app.UseHttpsRedirection();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
            //==============


        }


        public DataTable GetDataTable(string strSql, string p_sConnectString)
        {
            //by davidfujian (李顺道)
            //2004-2-28 Night
            //获得并返回表

            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable dtTab;
            var m_oConn = getConnectObj(p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strSql;
                sqlCmd.CommandTimeout = 9600;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtTab = new DataTable();
                sqlAdp.Fill(dtTab);

                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtTab.Rows.Count);
                        //s1trMsg += string.Format("|底层函数:[GetDataTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataTable]", objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }

                }

                //m_oConn.CloseB();
                return dtTab;
            }
            catch (Exception objException)
            {
                System.Console.Out.WriteLine("strSql = " + strSql);
                //LogError(objException, strSql);
                string strMsg = "";
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw new Exception(strMsg); //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);

            }
            finally
            {
                m_oConn.Close();
            }
        }
        public SqlConnection getConnectObj(string strConnectString)
        {
            SqlConnection objSqlConnect = null;
            try
            {
                objSqlConnect = new SqlConnection(strConnectString);
                objSqlConnect.Open();
                return objSqlConnect;
            }
            catch (Exception objException)
            {
                objSqlConnect.Dispose();
                objSqlConnect = null;
                //LogError(objException, "打开连接失败!");


                StringBuilder sbMessage = new StringBuilder();
                sbMessage.Append(objException.Message);
                sbMessage.Append("\r\n");
                sbMessage.Append("打开连接失败!请检查连接串!\r\n");
                string[] strItems = strConnectString.Split(';');
                //foreach (string strItem in strItems)
                //{
                //    string[] strKeyValue = strItem.Split('=');
                //    if (strKeyValue[0].Equals("server", StringComparison.CurrentCultureIgnoreCase) == true)
                //    {
                //        m_sServer = strKeyValue[1];
                //    }
                //    else if (strKeyValue[0].Equals("database", StringComparison.CurrentCultureIgnoreCase) == true)
                //    {
                //        m_sDatabase = strKeyValue[1];
                //    }
                //    else if (strKeyValue[0].Equals("uid", StringComparison.CurrentCultureIgnoreCase) == true)
                //    {
                //        m_sUid = strKeyValue[1];
                //    }
                //}
                //if (string.IsNullOrEmpty(m_sServer) == false)
                //{
                //    sbMessage.AppendFormat("打开的服务器：{0}，\r\n数据库：{1}。", //，\r\n用户名：{2}。",
                //        m_sServer,
                //        m_sDatabase,
                //        m_sUid);
                //}
                //if (clsDebugBase_Sql.IsDebug == true)
                //{
                //    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, sbMessage.ToString());
                //    StackTrace trace = new StackTrace();
                //    int intCurrLevel = 0;
                //    foreach (StackFrame frame in trace.GetFrames())
                //    {
                //        string strFileName = frame.GetFileName();
                //        string strMothodName = frame.GetMethod().Name;
                //        if (frame.GetMethod().DeclaringType == null) break;
                //        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                //        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                //        intCurrLevel++;
                //        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                //    }
                //    clsDebugBase_Sql.WriteLog(strMsg);
                //}
                //				sbMessage.Append("打开连接失败!请检查连接串!");
                throw new Exception(sbMessage.ToString(), objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            //finally
            //{
            //}
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.


        //public class Startup
        //{
        //    public Startup(IConfiguration configuration)
        //    {
        //        Configuration = configuration;
        //    }

        //    public IConfiguration Configuration { get; }

        //    // This method gets called by the runtime. Use this method to add services to the container.
        //    public void ConfigureServices(IServiceCollection services)
        //    {
        //        services.AddSession();
        //        services.AddRazorPages();
        //    }

        //    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //    {
        //        app.UseSession();
        //        if (env.IsDevelopment())
        //        {
        //            app.UseDeveloperExceptionPage();
        //        }
        //        else
        //        {
        //            app.UseExceptionHandler("/Error");
        //        }

        //        app.UseStaticFiles();

        //        app.UseRouting();

        //        app.UseAuthorization();

        //        app.UseEndpoints(endpoints =>
        //        {
        //            endpoints.MapRazorPages();
        //        });
        //    }
        //}
    }
}
