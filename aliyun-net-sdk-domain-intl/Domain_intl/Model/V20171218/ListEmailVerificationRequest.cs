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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain_intl.Transform;
using Aliyun.Acs.Domain_intl.Transform.V20171218;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
    public class ListEmailVerificationRequest : RpcAcsRequest<ListEmailVerificationResponse>
    {
        public ListEmailVerificationRequest()
            : base("Domain_intl", "2017-12-18", "ListEmailVerification", "domain", "openAPI")
        {
        }

		private long? beginCreateTime;

		private long? endCreateTime;

		private int? pageSize;

		private string lang;

		private int? pageNum;

		private string email;

		private int? verificationStatus;

		public long? BeginCreateTime
		{
			get
			{
				return beginCreateTime;
			}
			set	
			{
				beginCreateTime = value;
				DictionaryUtil.Add(QueryParameters, "BeginCreateTime", value.ToString());
			}
		}

		public long? EndCreateTime
		{
			get
			{
				return endCreateTime;
			}
			set	
			{
				endCreateTime = value;
				DictionaryUtil.Add(QueryParameters, "EndCreateTime", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set	
			{
				email = value;
				DictionaryUtil.Add(QueryParameters, "Email", value);
			}
		}

		public int? VerificationStatus
		{
			get
			{
				return verificationStatus;
			}
			set	
			{
				verificationStatus = value;
				DictionaryUtil.Add(QueryParameters, "VerificationStatus", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListEmailVerificationResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListEmailVerificationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}