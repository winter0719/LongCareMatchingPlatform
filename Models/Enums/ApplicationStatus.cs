namespace LongCareMatchingPlatform.Models.Enums
{
    /// <summary>
    /// 案件申請狀態列舉
    /// </summary>
    public enum ApplicationStatus
    {
        /// <summary>
        /// 待審核
        /// </summary>
        Pending = 0,

        /// <summary>
        /// 已接受
        /// </summary>
        Accepted = 1,

        /// <summary>
        /// 已拒絕
        /// </summary>
        Rejected = 2,

        /// <summary>
        /// 已取消
        /// </summary>
        Cancelled = 3
    }
}