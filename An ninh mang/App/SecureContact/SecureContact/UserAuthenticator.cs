﻿//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Security;
//using System.Security.Principal;

//namespace SecureContact
//{
//    public class UserAuthenticator : IHttpModule
//    {

//        public void Dispose()
//        {
//        }

//        public void Init(HttpApplication context)
//        {
//            application.AuthenticateRequest += new EventHandler(this.OnAuthenticateRequest);
//            application.EndRequest += new EventHandler(this.OnEndRequest);
//        }

//        public void OnAuthenticateRequest(object source, EventArgs e)
//        {
//            HttpApplication app = (HttpApplication)source;
//            string authHeader = app.Request.Headers["Authorization"];

//            if (!string.IsNullOrEmpty(authHeader))
//            {
//                string authStr = app.Request.Headers["Authorization"];

//                if (authStr == null || authStr.Length == 0)
//                {
//                    //anonymous
//                    return;
//                }

//                authStr = authStr.Trim();

//                if (authStr.IndexOf("Basic", 0) != 0)
//                {
//                    //header is not correct
//                    return;
//                }

//                authStr = authStr.Trim();

//                string encodedCredentials = authStr.Substring(6);

//                byte[] decodedBytes = Convert.FromBase64String(encodedCredentials);
//                string s = new ASCIIEncoding().GetString(decodedBytes);

//                string[] userPass = s.Split(new char[] { ':' });

//                string username = userPass[0];
//                string password = userPass[1];

//                if (Membership.ValidateUser(username, password))
//                {
//                    string[] roles = Roles.GetRolesForUser(username);
//                    app.Context.User = new GenericPrincipal(
//                        new GenericIdentity(username, "Membership Provider"), roles
//                        );
//                }
//                else
//                {
//                    DenyAccess(app);
//                    return;
//                }
//            }
//            else
//            {
//                app.Response.StatusCode = 401;
//                app.Response.End();
//            }
//        }

//        public void OnEndRequest(object sender, EventArgs e)
//        {
//            if (HttpContext.Current.Response.StatusCode == 401)
//            {
//                HttpContext context = HttpContext.Current;
//                context.Response.StatusCode = 401;
//                context.Response.AddHeader("WWW-Authenticate", "Basic Realm");
//            }
//        }

//        public void DenyAccess(HttpApplication app)
//        {
//            app.Response.StatusCode = 401;
//            app.Response.StatusDescription = "Access Denied";
//            // Write to response stream as well, to give user visual  
//            // indication of error during development 
//            app.Response.Write("401 Access Denied");

//            app.CompleteRequest();
//        }
//    }
//}