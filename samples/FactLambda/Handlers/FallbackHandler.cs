﻿using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Ask.Sdk.Core.Dispatcher.Request.Handler;
using FactLambda.Resources;
using System.Threading.Tasks;

namespace FactLambda.Handlers
{
    public class FallbackHandler : ICustomSkillRequestHandler
    {
        public Task<bool> CanHandle(IHandlerInput input)
        {
            if (input.RequestEnvelope.Request is IntentRequest intent)
            {
                return Task.FromResult(intent.Intent.Name == BuiltInIntent.Fallback);
            }

            return Task.FromResult(false);
        }

        public Task<ResponseBody> Handle(IHandlerInput input)
        {
            return Task.FromResult(input.ResponseBuilder
                .Speak(LanguageStrings.FallbackMessage)
                .Reprompt(LanguageStrings.FallbackReprompt)
                .GetResponse());
        }
    }
}
