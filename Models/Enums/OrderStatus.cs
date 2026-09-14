namespace LongCareMatchingPlatform.Models.Enums
{
    /// <summary>
    /// 訂單狀態列舉
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// 已確認
        /// </summary>
        Confirmed = 0,

        /// <summary>
        /// 進行中
        /// </summary>
        InProgress = 1,

        /// <summary>
        /// 已完成
        /// </summary>
        Completed = 2,

        /// <summary>
        /// 已取消
        /// </summary>
        Cancelled = 3
    }
}