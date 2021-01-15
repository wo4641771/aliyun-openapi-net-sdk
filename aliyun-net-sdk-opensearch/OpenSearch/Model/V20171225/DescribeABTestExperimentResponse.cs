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

namespace Aliyun.Acs.OpenSearch.Model.V20171225
{
	public class DescribeABTestExperimentResponse : AcsResponse
	{

		private string requestId;

		private DescribeABTestExperiment_Result result;

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

		public DescribeABTestExperiment_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeABTestExperiment_Result
		{

			private string id;

			private string name;

			private int? created;

			private int? updated;

			private bool? online;

			private int? traffic;

			private DescribeABTestExperiment__Params _params;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public int? Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
				}
			}

			public int? Updated
			{
				get
				{
					return updated;
				}
				set	
				{
					updated = value;
				}
			}

			public bool? Online
			{
				get
				{
					return online;
				}
				set	
				{
					online = value;
				}
			}

			public int? Traffic
			{
				get
				{
					return traffic;
				}
				set	
				{
					traffic = value;
				}
			}

			public DescribeABTestExperiment__Params _Params
			{
				get
				{
					return _params;
				}
				set	
				{
					_params = value;
				}
			}

			public class DescribeABTestExperiment__Params
			{

				private string first_formula_name;

				public string First_formula_name
				{
					get
					{
						return first_formula_name;
					}
					set	
					{
						first_formula_name = value;
					}
				}
			}
		}
	}
}
