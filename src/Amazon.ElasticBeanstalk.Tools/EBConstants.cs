﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Amazon.ElasticBeanstalk.Tools
{
    public static class EBConstants
    {
        public const string DEFAULT_MANIFEST = @"
{
  ""manifestVersion"": 1,
  ""deployments"": {

    ""aspNetCoreWeb"": [
      {
        ""name"": ""app"",
        ""parameters"": {
          ""appBundle"": ""."",
          ""iisPath"": ""{iisPath}"",
          ""iisWebSite"": ""{iisWebSite}""
        }
      }
    ]
  }
}
";

        public const string ENVIRONMENT_TYPE_SINGLEINSTANCE = "SingleInstance";
        public const string ENVIRONMENT_TYPE_LOADBALANCED = "LoadBalanced";

        public static readonly ImmutableArray<string> ValidEnhanceHealthType = ImmutableArray.Create("enhanced", "basic");


        public const string LOADBALANCER_TYPE_APPLICATION = "application";
        public const string LOADBALANCER_TYPE_NETWORK = "network";
        public const string LOADBALANCER_TYPE_CLASSIC = "classic";
        public static readonly ImmutableArray<string> ValidLoadBalancerType = ImmutableArray.Create(LOADBALANCER_TYPE_APPLICATION, LOADBALANCER_TYPE_NETWORK, LOADBALANCER_TYPE_CLASSIC);

    }
}
