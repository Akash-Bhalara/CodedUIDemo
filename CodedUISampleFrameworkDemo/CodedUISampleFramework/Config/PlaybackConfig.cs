using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using CodedUISampleFramework.Resources;

namespace CodedUISampleFramework.Config
{
    public class PlaybackConfig
    {
        /// <summary>
        /// Set the SearchTimeOut Playback Option
        /// </summary>
        public static void SetThinkSearchTimeOut()
        {
            Playback.PlaybackSettings.SearchTimeout = Convert.ToInt32(PlaybackConfiguration.SearchTimeOut);
        }

        public static void SetWaitForReadyTimeout()
        {
            Playback.PlaybackSettings.WaitForReadyTimeout = Convert.ToInt32(PlaybackConfiguration.WaitForReadyTimeOut);
        }

        /// <summary>
        /// Reset Playback Settings to Default
        /// </summary>
        public static void ResetPlaybackSettings()
        {
            Playback.PlaybackSettings.ResetToDefault();
        }

        
    }
}
