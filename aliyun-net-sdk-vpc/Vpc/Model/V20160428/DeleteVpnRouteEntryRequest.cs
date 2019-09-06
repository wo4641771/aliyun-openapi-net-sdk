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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class DeleteVpnRouteEntryRequest : RpcAcsRequest<DeleteVpnRouteEntryResponse>
    {
        public DeleteVpnRouteEntryRequest()
            : base("Vpc", "2016-04-28", "DeleteVpnRouteEntry", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? weight;

		private string vpnGatewayId;

		private long? ownerId;

		private string routeDest;

		private string nextHop;

		private string overlayMode;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public int? Weight
		{
			get
			{
				return weight;
			}
			set	
			{
				weight = value;
				DictionaryUtil.Add(QueryParameters, "Weight", value.ToString());
			}
		}

		public string VpnGatewayId
		{
			get
			{
				return vpnGatewayId;
			}
			set	
			{
				vpnGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "VpnGatewayId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string RouteDest
		{
			get
			{
				return routeDest;
			}
			set	
			{
				routeDest = value;
				DictionaryUtil.Add(QueryParameters, "RouteDest", value);
			}
		}

		public string NextHop
		{
			get
			{
				return nextHop;
			}
			set	
			{
				nextHop = value;
				DictionaryUtil.Add(QueryParameters, "NextHop", value);
			}
		}

		public string OverlayMode
		{
			get
			{
				return overlayMode;
			}
			set	
			{
				overlayMode = value;
				DictionaryUtil.Add(QueryParameters, "OverlayMode", value);
			}
		}

        public override DeleteVpnRouteEntryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteVpnRouteEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
