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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ValidateTrajectoryResponseUnmarshaller
    {
        public static ValidateTrajectoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ValidateTrajectoryResponse validateTrajectoryResponse = new ValidateTrajectoryResponse();

			validateTrajectoryResponse.HttpResponse = _ctx.HttpResponse;
			validateTrajectoryResponse.Code = _ctx.IntegerValue("ValidateTrajectory.Code");
			validateTrajectoryResponse.Data = _ctx.StringValue("ValidateTrajectory.Data");
			validateTrajectoryResponse.Message = _ctx.StringValue("ValidateTrajectory.Message");
			validateTrajectoryResponse.RequestId = _ctx.StringValue("ValidateTrajectory.RequestId");
			validateTrajectoryResponse.Success = _ctx.BooleanValue("ValidateTrajectory.Success");
        
			return validateTrajectoryResponse;
        }
    }
}
