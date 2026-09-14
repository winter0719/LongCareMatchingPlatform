namespace LongCareMatchingPlatform.Models.Enums
{
    /// <summary>
    /// 長照需求案件狀態列舉
    /// </summary>
    public enum CareRequestStatus
    {
        /// <summary>
        /// 開放申請
        /// </summary>
        Open = 0,

        /// <summary>
        /// 已媒合
        /// </summary>
        Matched = 1,

        /// <summary>
        /// 進行中
        /// </summary>
        InProgress = 2,

        /// <summary>
        /// 已完成
        /// </summary>
        Completed = 3,

        /// <summary>
        /// 已取消
        /// </summary>
        Cancelled = 4
    }
}