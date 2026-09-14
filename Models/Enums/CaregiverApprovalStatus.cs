namespace LongCareMatchingPlatform.Models.Enums
{
    /// <summary>
    /// 照服員審核狀態列舉
    /// </summary>
    public enum CaregiverApprovalStatus
    {
        /// <summary>
        /// 待審核
        /// </summary>
        Pending = 0,

        /// <summary>
        /// 已通過
        /// </summary>
        Approved = 1,

        /// <summary>
        /// 已駁回
        /// </summary>
        Rejected = 2
    }
}