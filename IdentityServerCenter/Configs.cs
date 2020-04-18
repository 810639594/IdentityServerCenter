using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerCenter
{
    public class Configs
    {
        public static IEnumerable<ApiResource> GetResources()
        {
            return new List<ApiResource>()
            {
                new ApiResource("api", "My API")
            };
        }
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                    ClientId="client",
                    AllowedGrantTypes = {GrantType.ClientCredentials},//认证方式
                    AllowedScopes={"api"},//可以访问的资源
                    ClientSecrets = {  new Secret("secret".Sha256()) }//加密

                },
                 new Client()
                {
                    ClientId="clientpwd",
                    AllowedGrantTypes = {GrantType.ResourceOwnerPassword},//认证方式
                    AllowedScopes={"api"},//可以访问的资源
                    ClientSecrets = {  new Secret("secret".Sha256()) }//加密
                }
            };
        }
        public static List<TestUser> GetTestUsers()
        {
            return new  List<TestUser>(){
                new TestUser()
                {
                    SubjectId="001",
                    Username="wsd",
                    Password="wsd"
                }
            };
        }

    }
}
