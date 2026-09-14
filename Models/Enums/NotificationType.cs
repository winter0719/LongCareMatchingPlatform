namespace LongCareMatchingPlatform.Models.Enums
{
    /// <summary>
    /// 通知類型列舉
    /// </summary>
    public enum NotificationType
    {
        /// <summary>
        /// 收到申請
        /// </summary>
        ApplicationReceived = 0,

        /// <summary>
        /// 媒合成功
        /// </summary>
        MatchedSuccessfully = 1,

        /// <summary>
        /// 申請被拒
        /// </summary>
        ApplicationRejected = 2,

        /// <summary>
        /// 照服員通過審核
        /// </summary>
        CaregiverApproved = 3,

        /// <summary>
        /// 照服員審核被駁回
        /// </summary>
        CaregiverRejected = 4,

        /// <summary>
        /// 系統公告
        /// </summary>
        SystemAnnouncement = 5
    }
}