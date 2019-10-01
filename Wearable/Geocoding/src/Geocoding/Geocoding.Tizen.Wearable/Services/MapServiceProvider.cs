/*
 * Copyright (c) 2019 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using Geocoding.Tizen.Wearable.Services;
using Tizen.Maps;

[assembly: Xamarin.Forms.Dependency(typeof(MapServiceProvider))]
namespace Geocoding.Tizen.Wearable.Services
{
    /// <summary>
    /// Provides an instance of the map service class to other application modules.
    /// </summary>
    class MapServiceProvider : IMapServiceProvider
    {
        #region fields

        /// <summary>
        /// An instance of the map service class provided by the Tizen API.
        /// </summary>
        private MapService _mapService;

        #endregion

        #region methods

        /// <summary>
        /// Initializes class instance.
        /// </summary>
        public MapServiceProvider()
        {
            _mapService = new MapService(Config.ProviderName, Config.AuthenticationToken);
        }

        /// <summary>
        /// Returns an instance of the map service class.
        /// </summary>
        /// <returns>An instance of the map service class.</returns>
        public MapService GetService()
        {
            return _mapService;
        }

        #endregion
    }
}
