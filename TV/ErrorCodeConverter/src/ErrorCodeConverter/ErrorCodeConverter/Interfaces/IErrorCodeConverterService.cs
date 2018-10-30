/*
 * Copyright 2018 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://floralicense.org/license
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace ErrorCodeConverter.Interfaces
{
    /// <summary>
    /// Interface used to obtaining platform specific implementation of
    /// error codes converting service.
    /// </summary>
    public interface IErrorCodeConverterService
    {
        #region methods

        /// <summary>
        /// Returns error message for code number provided as parameter.
        /// </summary>
        /// <param name="code">Error code.</param>
        /// <returns>Error message.</returns>
        string GetMessageFromCode(int code);

        #endregion
    }
}
