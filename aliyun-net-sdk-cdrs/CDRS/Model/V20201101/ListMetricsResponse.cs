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

namespace Aliyun.Acs.CDRS.Model.V20201101
{
	public class ListMetricsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private string pageNumber;

		private string pageSize;

		private string totalCount;

		private List<ListMetrics_DataItem> data;

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

		public string PageNumber
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

		public string PageSize
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

		public string TotalCount
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

		public List<ListMetrics_DataItem> Data
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

		public class ListMetrics_DataItem
		{

			private string dateTime;

			private string tagCode;

			private string tagValue;

			private string tagMetric;

			private string corpId;

			public string DateTime
			{
				get
				{
					return dateTime;
				}
				set	
				{
					dateTime = value;
				}
			}

			public string TagCode
			{
				get
				{
					return tagCode;
				}
				set	
				{
					tagCode = value;
				}
			}

			public string TagValue
			{
				get
				{
					return tagValue;
				}
				set	
				{
					tagValue = value;
				}
			}

			public string TagMetric
			{
				get
				{
					return tagMetric;
				}
				set	
				{
					tagMetric = value;
				}
			}

			public string CorpId
			{
				get
				{
					return corpId;
				}
				set	
				{
					corpId = value;
				}
			}
		}
	}
}
