#if ENABLE_PLAYFABADMIN_API
using PlayFab.AdminModels;
using PlayFab.Internal;

namespace PlayFab.Events
{
    public partial class PlayFabEvents
    {
        
        
        public event PlayFabRequestEvent<LookupUserAccountInfoRequest> OnAdminGetUserAccountInfoRequestEvent;
        public event PlayFabResultEvent<LookupUserAccountInfoResult> OnAdminGetUserAccountInfoResultEvent;
        public event PlayFabRequestEvent<ResetUsersRequest> OnAdminResetUsersRequestEvent;
        public event PlayFabResultEvent<BlankResult> OnAdminResetUsersResultEvent;
        public event PlayFabRequestEvent<SendAccountRecoveryEmailRequest> OnAdminSendAccountRecoveryEmailRequestEvent;
        public event PlayFabResultEvent<SendAccountRecoveryEmailResult> OnAdminSendAccountRecoveryEmailResultEvent;
        public event PlayFabRequestEvent<UpdateUserTitleDisplayNameRequest> OnAdminUpdateUserTitleDisplayNameRequestEvent;
        public event PlayFabResultEvent<UpdateUserTitleDisplayNameResult> OnAdminUpdateUserTitleDisplayNameResultEvent;
        public event PlayFabRequestEvent<CreatePlayerStatisticDefinitionRequest> OnAdminCreatePlayerStatisticDefinitionRequestEvent;
        public event PlayFabResultEvent<CreatePlayerStatisticDefinitionResult> OnAdminCreatePlayerStatisticDefinitionResultEvent;
        public event PlayFabRequestEvent<DeleteUsersRequest> OnAdminDeleteUsersRequestEvent;
        public event PlayFabResultEvent<DeleteUsersResult> OnAdminDeleteUsersResultEvent;
        public event PlayFabRequestEvent<GetDataReportRequest> OnAdminGetDataReportRequestEvent;
        public event PlayFabResultEvent<GetDataReportResult> OnAdminGetDataReportResultEvent;
        public event PlayFabRequestEvent<GetPlayerStatisticDefinitionsRequest> OnAdminGetPlayerStatisticDefinitionsRequestEvent;
        public event PlayFabResultEvent<GetPlayerStatisticDefinitionsResult> OnAdminGetPlayerStatisticDefinitionsResultEvent;
        public event PlayFabRequestEvent<GetPlayerStatisticVersionsRequest> OnAdminGetPlayerStatisticVersionsRequestEvent;
        public event PlayFabResultEvent<GetPlayerStatisticVersionsResult> OnAdminGetPlayerStatisticVersionsResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnAdminGetUserDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnAdminGetUserDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnAdminGetUserInternalDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnAdminGetUserInternalDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnAdminGetUserPublisherDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnAdminGetUserPublisherDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnAdminGetUserPublisherInternalDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnAdminGetUserPublisherInternalDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnAdminGetUserPublisherReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnAdminGetUserPublisherReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnAdminGetUserReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnAdminGetUserReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<IncrementPlayerStatisticVersionRequest> OnAdminIncrementPlayerStatisticVersionRequestEvent;
        public event PlayFabResultEvent<IncrementPlayerStatisticVersionResult> OnAdminIncrementPlayerStatisticVersionResultEvent;
        public event PlayFabRequestEvent<ResetUserStatisticsRequest> OnAdminResetUserStatisticsRequestEvent;
        public event PlayFabResultEvent<ResetUserStatisticsResult> OnAdminResetUserStatisticsResultEvent;
        public event PlayFabRequestEvent<UpdatePlayerStatisticDefinitionRequest> OnAdminUpdatePlayerStatisticDefinitionRequestEvent;
        public event PlayFabResultEvent<UpdatePlayerStatisticDefinitionResult> OnAdminUpdatePlayerStatisticDefinitionResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnAdminUpdateUserDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnAdminUpdateUserDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserInternalDataRequest> OnAdminUpdateUserInternalDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnAdminUpdateUserInternalDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnAdminUpdateUserPublisherDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnAdminUpdateUserPublisherDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserInternalDataRequest> OnAdminUpdateUserPublisherInternalDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnAdminUpdateUserPublisherInternalDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnAdminUpdateUserPublisherReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnAdminUpdateUserPublisherReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnAdminUpdateUserReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnAdminUpdateUserReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<AddNewsRequest> OnAdminAddNewsRequestEvent;
        public event PlayFabResultEvent<AddNewsResult> OnAdminAddNewsResultEvent;
        public event PlayFabRequestEvent<AddVirtualCurrencyTypesRequest> OnAdminAddVirtualCurrencyTypesRequestEvent;
        public event PlayFabResultEvent<BlankResult> OnAdminAddVirtualCurrencyTypesResultEvent;
        public event PlayFabRequestEvent<GetCatalogItemsRequest> OnAdminGetCatalogItemsRequestEvent;
        public event PlayFabResultEvent<GetCatalogItemsResult> OnAdminGetCatalogItemsResultEvent;
        public event PlayFabRequestEvent<GetPublisherDataRequest> OnAdminGetPublisherDataRequestEvent;
        public event PlayFabResultEvent<GetPublisherDataResult> OnAdminGetPublisherDataResultEvent;
        public event PlayFabRequestEvent<GetRandomResultTablesRequest> OnAdminGetRandomResultTablesRequestEvent;
        public event PlayFabResultEvent<GetRandomResultTablesResult> OnAdminGetRandomResultTablesResultEvent;
        public event PlayFabRequestEvent<GetStoreItemsRequest> OnAdminGetStoreItemsRequestEvent;
        public event PlayFabResultEvent<GetStoreItemsResult> OnAdminGetStoreItemsResultEvent;
        public event PlayFabRequestEvent<GetTitleDataRequest> OnAdminGetTitleDataRequestEvent;
        public event PlayFabResultEvent<GetTitleDataResult> OnAdminGetTitleDataResultEvent;
        public event PlayFabRequestEvent<GetTitleDataRequest> OnAdminGetTitleInternalDataRequestEvent;
        public event PlayFabResultEvent<GetTitleDataResult> OnAdminGetTitleInternalDataResultEvent;
        public event PlayFabRequestEvent<ListVirtualCurrencyTypesRequest> OnAdminListVirtualCurrencyTypesRequestEvent;
        public event PlayFabResultEvent<ListVirtualCurrencyTypesResult> OnAdminListVirtualCurrencyTypesResultEvent;
        public event PlayFabRequestEvent<RemoveVirtualCurrencyTypesRequest> OnAdminRemoveVirtualCurrencyTypesRequestEvent;
        public event PlayFabResultEvent<BlankResult> OnAdminRemoveVirtualCurrencyTypesResultEvent;
        public event PlayFabRequestEvent<UpdateCatalogItemsRequest> OnAdminSetCatalogItemsRequestEvent;
        public event PlayFabResultEvent<UpdateCatalogItemsResult> OnAdminSetCatalogItemsResultEvent;
        public event PlayFabRequestEvent<UpdateStoreItemsRequest> OnAdminSetStoreItemsRequestEvent;
        public event PlayFabResultEvent<UpdateStoreItemsResult> OnAdminSetStoreItemsResultEvent;
        public event PlayFabRequestEvent<SetTitleDataRequest> OnAdminSetTitleDataRequestEvent;
        public event PlayFabResultEvent<SetTitleDataResult> OnAdminSetTitleDataResultEvent;
        public event PlayFabRequestEvent<SetTitleDataRequest> OnAdminSetTitleInternalDataRequestEvent;
        public event PlayFabResultEvent<SetTitleDataResult> OnAdminSetTitleInternalDataResultEvent;
        public event PlayFabRequestEvent<SetupPushNotificationRequest> OnAdminSetupPushNotificationRequestEvent;
        public event PlayFabResultEvent<SetupPushNotificationResult> OnAdminSetupPushNotificationResultEvent;
        public event PlayFabRequestEvent<UpdateCatalogItemsRequest> OnAdminUpdateCatalogItemsRequestEvent;
        public event PlayFabResultEvent<UpdateCatalogItemsResult> OnAdminUpdateCatalogItemsResultEvent;
        public event PlayFabRequestEvent<UpdateRandomResultTablesRequest> OnAdminUpdateRandomResultTablesRequestEvent;
        public event PlayFabResultEvent<UpdateRandomResultTablesResult> OnAdminUpdateRandomResultTablesResultEvent;
        public event PlayFabRequestEvent<UpdateStoreItemsRequest> OnAdminUpdateStoreItemsRequestEvent;
        public event PlayFabResultEvent<UpdateStoreItemsResult> OnAdminUpdateStoreItemsResultEvent;
        public event PlayFabRequestEvent<AddUserVirtualCurrencyRequest> OnAdminAddUserVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyUserVirtualCurrencyResult> OnAdminAddUserVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<GetUserInventoryRequest> OnAdminGetUserInventoryRequestEvent;
        public event PlayFabResultEvent<GetUserInventoryResult> OnAdminGetUserInventoryResultEvent;
        public event PlayFabRequestEvent<GrantItemsToUsersRequest> OnAdminGrantItemsToUsersRequestEvent;
        public event PlayFabResultEvent<GrantItemsToUsersResult> OnAdminGrantItemsToUsersResultEvent;
        public event PlayFabRequestEvent<RevokeInventoryItemRequest> OnAdminRevokeInventoryItemRequestEvent;
        public event PlayFabResultEvent<RevokeInventoryResult> OnAdminRevokeInventoryItemResultEvent;
        public event PlayFabRequestEvent<SubtractUserVirtualCurrencyRequest> OnAdminSubtractUserVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyUserVirtualCurrencyResult> OnAdminSubtractUserVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<GetMatchmakerGameInfoRequest> OnAdminGetMatchmakerGameInfoRequestEvent;
        public event PlayFabResultEvent<GetMatchmakerGameInfoResult> OnAdminGetMatchmakerGameInfoResultEvent;
        public event PlayFabRequestEvent<GetMatchmakerGameModesRequest> OnAdminGetMatchmakerGameModesRequestEvent;
        public event PlayFabResultEvent<GetMatchmakerGameModesResult> OnAdminGetMatchmakerGameModesResultEvent;
        public event PlayFabRequestEvent<ModifyMatchmakerGameModesRequest> OnAdminModifyMatchmakerGameModesRequestEvent;
        public event PlayFabResultEvent<ModifyMatchmakerGameModesResult> OnAdminModifyMatchmakerGameModesResultEvent;
        public event PlayFabRequestEvent<AddServerBuildRequest> OnAdminAddServerBuildRequestEvent;
        public event PlayFabResultEvent<AddServerBuildResult> OnAdminAddServerBuildResultEvent;
        public event PlayFabRequestEvent<GetServerBuildInfoRequest> OnAdminGetServerBuildInfoRequestEvent;
        public event PlayFabResultEvent<GetServerBuildInfoResult> OnAdminGetServerBuildInfoResultEvent;
        public event PlayFabRequestEvent<GetServerBuildUploadURLRequest> OnAdminGetServerBuildUploadUrlRequestEvent;
        public event PlayFabResultEvent<GetServerBuildUploadURLResult> OnAdminGetServerBuildUploadUrlResultEvent;
        public event PlayFabRequestEvent<ListBuildsRequest> OnAdminListServerBuildsRequestEvent;
        public event PlayFabResultEvent<ListBuildsResult> OnAdminListServerBuildsResultEvent;
        public event PlayFabRequestEvent<ModifyServerBuildRequest> OnAdminModifyServerBuildRequestEvent;
        public event PlayFabResultEvent<ModifyServerBuildResult> OnAdminModifyServerBuildResultEvent;
        public event PlayFabRequestEvent<RemoveServerBuildRequest> OnAdminRemoveServerBuildRequestEvent;
        public event PlayFabResultEvent<RemoveServerBuildResult> OnAdminRemoveServerBuildResultEvent;
        public event PlayFabRequestEvent<SetPublisherDataRequest> OnAdminSetPublisherDataRequestEvent;
        public event PlayFabResultEvent<SetPublisherDataResult> OnAdminSetPublisherDataResultEvent;
        public event PlayFabRequestEvent<GetCloudScriptRevisionRequest> OnAdminGetCloudScriptRevisionRequestEvent;
        public event PlayFabResultEvent<GetCloudScriptRevisionResult> OnAdminGetCloudScriptRevisionResultEvent;
        public event PlayFabRequestEvent<GetCloudScriptVersionsRequest> OnAdminGetCloudScriptVersionsRequestEvent;
        public event PlayFabResultEvent<GetCloudScriptVersionsResult> OnAdminGetCloudScriptVersionsResultEvent;
        public event PlayFabRequestEvent<SetPublishedRevisionRequest> OnAdminSetPublishedRevisionRequestEvent;
        public event PlayFabResultEvent<SetPublishedRevisionResult> OnAdminSetPublishedRevisionResultEvent;
        public event PlayFabRequestEvent<UpdateCloudScriptRequest> OnAdminUpdateCloudScriptRequestEvent;
        public event PlayFabResultEvent<UpdateCloudScriptResult> OnAdminUpdateCloudScriptResultEvent;
        public event PlayFabRequestEvent<DeleteContentRequest> OnAdminDeleteContentRequestEvent;
        public event PlayFabResultEvent<BlankResult> OnAdminDeleteContentResultEvent;
        public event PlayFabRequestEvent<GetContentListRequest> OnAdminGetContentListRequestEvent;
        public event PlayFabResultEvent<GetContentListResult> OnAdminGetContentListResultEvent;
        public event PlayFabRequestEvent<GetContentUploadUrlRequest> OnAdminGetContentUploadUrlRequestEvent;
        public event PlayFabResultEvent<GetContentUploadUrlResult> OnAdminGetContentUploadUrlResultEvent;
        public event PlayFabRequestEvent<ResetCharacterStatisticsRequest> OnAdminResetCharacterStatisticsRequestEvent;
        public event PlayFabResultEvent<ResetCharacterStatisticsResult> OnAdminResetCharacterStatisticsResultEvent;
        public event PlayFabRequestEvent<GetAllSegmentsRequest> OnAdminGetAllSegmentsRequestEvent;
        public event PlayFabResultEvent<GetAllSegmentsResult> OnAdminGetAllSegmentsResultEvent;
        public event PlayFabRequestEvent<GetPlayersSegmentsRequest> OnAdminGetPlayerSegmentsRequestEvent;
        public event PlayFabResultEvent<GetPlayerSegmentsResult> OnAdminGetPlayerSegmentsResultEvent;
        public event PlayFabRequestEvent<GetPlayersInSegmentRequest> OnAdminGetPlayersInSegmentRequestEvent;
        public event PlayFabResultEvent<GetPlayersInSegmentResult> OnAdminGetPlayersInSegmentResultEvent;
    }
}
#endif
