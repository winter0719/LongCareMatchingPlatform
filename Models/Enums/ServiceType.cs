namespace LongCareMatchingPlatform.Models.Enums
{
    /// <summary>
    /// 服務類型列舉
    /// </summary>
    public enum ServiceType
    {
        /// <summary>
        /// 日常身體照護
        /// </summary>
        DailyBodyCare = 0,

        /// <summary>
        /// 醫療照護
        /// </summary>
        MedicalCare = 1,

        /// <summary>
        /// 陪伴照護
        /// </summary>
        Companionship = 2,

        /// <summary>
        /// 用藥提醒
        /// </summary>
        MedicationReminder = 3,

        /// <summary>
        /// 回診提醒
        /// </summary>
        FollowUpReminder = 4,

        /// <summary>
        /// 家務協助
        /// </summary>
        HomeCleaningSupport = 5
    }
}