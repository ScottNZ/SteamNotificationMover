/*
 * Copyright 2015 SteamNotificationMover Developers
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using ColossalFramework.Steamworks;
using ICities;

namespace SteamNotificationMover
{
	public class Mod : IUserMod
	{
		public string Description
		{
			get { return "Moves Steam notification popups to the top right corner of the screen"; }
		}

		public string Name
		{
			get { return "Steam Notification Mover"; }
		}
	}

	public class LoadingExtension : LoadingExtensionBase
	{
		public override void OnCreated(ILoading loading)
		{
			Steam.SetOverlayNotificationPosition(NotificationPosition.TopRight);
		}

		public override void OnReleased()
		{
			Steam.SetOverlayNotificationPosition(NotificationPosition.BottomRight);
		}
	}
}
