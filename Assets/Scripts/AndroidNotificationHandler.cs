using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
#if UNITY_ANDROID
using Unity.Notifications.Android;
#endif

public class AndroidNotificationHandler : MonoBehaviour
{
#if UNITY_ANDROID
    const string ChannelId = "notification_channel";

    public void ScheduleNotification(DateTime dateTime)
    {
        AndroidNotificationChannel notificationChannel = new AndroidNotificationChannel
        {
            Id = ChannelId,
            Name = "Notification Channel",
            Description = "Some random description",
            Importance = Importance.Default
        };

        AndroidNotificationCenter.RegisterNotificationChannel(notificationChannel);

        AndroidNotification notification = new AndroidNotification
        {
            Title = "Energy Recharged!",
            Text = "Your energy has recharged, come back to play again",
            SmallIcon = "default",
            LargeIcon = "default",
            FireTime = dateTime
        };

        AndroidNotificationCenter.SendNotification(notification, C  hannelId);
    }
#endif
}
