/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class GetFaceModelResultRequest : RpcAcsRequest<GetFaceModelResultResponse>
    {
        public GetFaceModelResultRequest()
            : base("Vcs", "2020-05-15", "GetFaceModelResult", "vcs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string pictureUrl;

		private string pictureContent;

		private string pictureId;

		public string PictureUrl
		{
			get
			{
				return pictureUrl;
			}
			set	
			{
				pictureUrl = value;
				DictionaryUtil.Add(BodyParameters, "PictureUrl", value);
			}
		}

		public string PictureContent
		{
			get
			{
				return pictureContent;
			}
			set	
			{
				pictureContent = value;
				DictionaryUtil.Add(BodyParameters, "PictureContent", value);
			}
		}

		public string PictureId
		{
			get
			{
				return pictureId;
			}
			set	
			{
				pictureId = value;
				DictionaryUtil.Add(BodyParameters, "PictureId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetFaceModelResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetFaceModelResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
