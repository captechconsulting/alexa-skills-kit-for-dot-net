﻿using System.Runtime.Serialization;

namespace Ask.Sdk.Model.Request.Type
{
    public enum ErrorType
    {
        [EnumMember(Value = "INVALID_RESPONSE")]
        InvalidResponse,
        [EnumMember(Value = "DEVICE_COMMUNICATION_ERROR")]
        DeviceCommunicationError,
        [EnumMember(Value = "INTERNAL_ERROR")]
        InternalError,
        [EnumMember(Value = "MEDIA_ERROR_UNKNOWN")]
        MediaErrorUnknown,
        [EnumMember(Value = "MEDIA_ERROR_INVALID_REQUEST")]
        InvalidMediaRequest,
        [EnumMember(Value = "MEDIA_ERROR_SERVICE_UNAVAILABLE")]
        MediaServiceUnavailable,
        [EnumMember(Value = "MEDIA_ERROR_INTERNAL_SERVER_ERROR")]
        InternalServerError,
        [EnumMember(Value = "MEDIA_ERROR_INTERNAL_DEVICE_ERROR")]
        InternalDeviceError
    }
}