﻿

namespace getAddress.Sdk.Api.Responses
{
    public abstract class GetDomainWhitelistResponse: AdminResponse
    {

        protected GetDomainWhitelistResponse(int statusCode, string reasonPhase, string raw, bool isSuccess):base(statusCode,reasonPhase,raw,isSuccess)
        {
        
        }

        public class Success: GetDomainWhitelistResponse
        {
            public string Id { get; set; }

            public string Name { get; set; }

            internal Success(int statusCode, string reasonPhase, string raw,string id, string name):base(statusCode, reasonPhase, raw,true)
            {
                Id = id;
                Name = name;
            }
        }

        public class Failed : GetDomainWhitelistResponse
        {
            internal Failed(int statusCode, string reasonPhase, string raw) :base(statusCode, reasonPhase, raw, false)
            {

            }
        }
    }
}
