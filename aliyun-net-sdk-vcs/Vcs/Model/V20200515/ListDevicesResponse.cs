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

namespace Aliyun.Acs.Vcs.Model.V20200515
{
	public class ListDevicesResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private ListDevices_Data data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public ListDevices_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListDevices_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private int? totalPage;

			private List<ListDevices_Record> records;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
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
				}
			}

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public int? TotalPage
			{
				get
				{
					return totalPage;
				}
				set	
				{
					totalPage = value;
				}
			}

			public List<ListDevices_Record> Records
			{
				get
				{
					return records;
				}
				set	
				{
					records = value;
				}
			}

			public class ListDevices_Record
			{

				private string accessProtocolType;

				private string bitRate;

				private string coverImageUrl;

				private string gbId;

				private string deviceAddress;

				private string deviceDirection;

				private string deviceSite;

				private string latitude;

				private string longitude;

				private string deviceName;

				private string resolution;

				private string sipGBId;

				private string sipPassword;

				private string sipServerIp;

				private string sipServerPort;

				private int? status;

				private string deviceType;

				private string vendor;

				private string createTime;

				public string AccessProtocolType
				{
					get
					{
						return accessProtocolType;
					}
					set	
					{
						accessProtocolType = value;
					}
				}

				public string BitRate
				{
					get
					{
						return bitRate;
					}
					set	
					{
						bitRate = value;
					}
				}

				public string CoverImageUrl
				{
					get
					{
						return coverImageUrl;
					}
					set	
					{
						coverImageUrl = value;
					}
				}

				public string GbId
				{
					get
					{
						return gbId;
					}
					set	
					{
						gbId = value;
					}
				}

				public string DeviceAddress
				{
					get
					{
						return deviceAddress;
					}
					set	
					{
						deviceAddress = value;
					}
				}

				public string DeviceDirection
				{
					get
					{
						return deviceDirection;
					}
					set	
					{
						deviceDirection = value;
					}
				}

				public string DeviceSite
				{
					get
					{
						return deviceSite;
					}
					set	
					{
						deviceSite = value;
					}
				}

				public string Latitude
				{
					get
					{
						return latitude;
					}
					set	
					{
						latitude = value;
					}
				}

				public string Longitude
				{
					get
					{
						return longitude;
					}
					set	
					{
						longitude = value;
					}
				}

				public string DeviceName
				{
					get
					{
						return deviceName;
					}
					set	
					{
						deviceName = value;
					}
				}

				public string Resolution
				{
					get
					{
						return resolution;
					}
					set	
					{
						resolution = value;
					}
				}

				public string SipGBId
				{
					get
					{
						return sipGBId;
					}
					set	
					{
						sipGBId = value;
					}
				}

				public string SipPassword
				{
					get
					{
						return sipPassword;
					}
					set	
					{
						sipPassword = value;
					}
				}

				public string SipServerIp
				{
					get
					{
						return sipServerIp;
					}
					set	
					{
						sipServerIp = value;
					}
				}

				public string SipServerPort
				{
					get
					{
						return sipServerPort;
					}
					set	
					{
						sipServerPort = value;
					}
				}

				public int? Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string DeviceType
				{
					get
					{
						return deviceType;
					}
					set	
					{
						deviceType = value;
					}
				}

				public string Vendor
				{
					get
					{
						return vendor;
					}
					set	
					{
						vendor = value;
					}
				}

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}
			}
		}
	}
}
