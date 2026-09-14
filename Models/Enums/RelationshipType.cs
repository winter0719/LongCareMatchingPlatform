namespace LongCareMatchingPlatform.Models.Enums
{
    /// <summary>
    /// 家屬與被照護者關係類型列舉
    /// </summary>
    public enum RelationshipType
    {
        /// <summary>
        /// 子女
        /// </summary>
        Child = 0,

        /// <summary>
        /// 配偶
        /// </summary>
        Spouse = 1,

        /// <summary>
        /// 兄妹
        /// </summary>
        Sibling = 2,

        /// <summary>
        /// 父母
        /// </summary>
        Parent = 3,

        /// <summary>
        /// 孫子女
        /// </summary>
        Grandchild = 4,

        /// <summary>
        /// 其他
        /// </summary>
        Other = 5
    }
}