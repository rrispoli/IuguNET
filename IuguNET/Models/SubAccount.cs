using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace IuguNET.Models
{
    public class SubAccount : Base
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("can_receive?")]
        public bool CanReceive { get; set; }

        [JsonProperty("is_verified?")]
        public bool IsVerified { get; set; }

        [JsonProperty("last_verification_request_status")]
        public string LastVerificationRequestStatus { get; set; }

        [JsonProperty("last_verification_request_data")]
        public object LastVerificationRequestData { get; set; }

        [JsonProperty("last_verification_request_feedback")]
        public object LastVerificationRequestFeedback { get; set; }

        [JsonProperty("change_plan_type")]
        public int ChangePlanType { get; set; }

        [JsonProperty("subscriptions_trial_period")]
        public int SubscriptionsTrialPeriod { get; set; }

        [JsonProperty("subscriptions_billing_days")]
        public object SubscriptionsBillingDays { get; set; }

        [JsonProperty("disable_emails")]
        public bool DisableEmails { get; set; }

        [JsonProperty("last_withdraw")]
        public object LastWithdraw { get; set; }

        [JsonProperty("reply_to")]
        public string ReplyTo { get; set; }

        [JsonProperty("webapp_on_test_mode")]
        public bool WebappOnTestMode { get; set; }

        [JsonProperty("marketplace")]
        public bool Marketplace { get; set; }

        [JsonProperty("default_return_url")]
        public string DefaultReturnUrl { get; set; }

        [JsonProperty("credit_card_verified")]
        public bool CreditCardVerified { get; set; }

        [JsonProperty("fines")]
        public bool Fines { get; set; }

        [JsonProperty("late_payment_fine")]
        public int LatePaymentFine { get; set; }

        [JsonProperty("per_day_interest")]
        public bool PerDayInterest { get; set; }

        [JsonProperty("old_advancement")]
        public bool OldAdvancement { get; set; }

        [JsonProperty("auto_withdraw")]
        public bool AutoWithdraw { get; set; }

        [JsonProperty("payment_email_notification")]
        public bool PaymentEmailNotification { get; set; }

        [JsonProperty("payment_email_notification_receiver")]
        public object PaymentEmailNotificationReceiver { get; set; }

        [JsonProperty("auto_advance")]
        public bool AutoAdvance { get; set; }

        [JsonProperty("auto_advance_type")]
        public object AutoAdvanceType { get; set; }

        [JsonProperty("auto_advance_option")]
        public object AutoAdvanceOption { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("balance_in_protest")]
        public string BalanceInProtest { get; set; }

        [JsonProperty("balance_available_for_withdraw")]
        public string BalanceAvailableForWithdraw { get; set; }

        [JsonProperty("protected_balance")]
        public string ProtectedBalance { get; set; }

        [JsonProperty("payable_balance")]
        public string PayableBalance { get; set; }

        [JsonProperty("receivable_balance")]
        public string ReceivableBalance { get; set; }

        [JsonProperty("commission_balance")]
        public string CommissionBalance { get; set; }

        [JsonProperty("volume_last_month")]
        public string VolumeLastMonth { get; set; }

        [JsonProperty("volume_this_month")]
        public string VolumeThisMonth { get; set; }

        [JsonProperty("total_subscriptions")]
        public int TotalSubscriptions { get; set; }

        [JsonProperty("total_active_subscriptions")]
        public int TotalActiveSubscriptions { get; set; }

        [JsonProperty("taxes_paid_last_month")]
        public string TaxesPaidLastMonth { get; set; }

        [JsonProperty("taxes_paid_this_month")]
        public string TaxesPaidThisMonth { get; set; }

        [JsonProperty("permissions")]
        public IList<string> Permissions { get; set; }

        [JsonProperty("custom_logo_url")]
        public string CustomLogoUrl { get; set; }

        [JsonProperty("custom_logo_small_url")]
        public string CustomLogoSmallUrl { get; set; }

        [JsonProperty("informations")]
        public IList<Information> Informations { get; set; }

        [JsonProperty("configuration")]
        public SubAccountConfiguration Configuration { get; set; }
    }
}
