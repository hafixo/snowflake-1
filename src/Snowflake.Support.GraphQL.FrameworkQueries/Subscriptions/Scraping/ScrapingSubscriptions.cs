﻿using HotChocolate.Resolvers;
using HotChocolate.Types;
using Snowflake.Extensibility.Queueing;
using Snowflake.Scraping;
using Snowflake.Support.GraphQL.FrameworkQueries.Mutations.Scraping;
using System;
using System.Collections.Generic;
using System.Text;
using Snowflake.Remoting.GraphQL;
using Snowflake.Model.Game;
using Snowflake.Scraping.Extensibility;
using Snowflake.Services;
using System.Linq;

namespace Snowflake.Support.GraphQL.FrameworkQueries.Subscriptions.Scraping
{
    internal sealed class ScrapingSubscriptions
        : ObjectTypeExtension
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.ExtendSubscription();

            descriptor.Field("onScrapeContextStep")
                .Description("A subscription for when a scrape context step occurs.")
                .Type<NonNullType<ScrapeContextStepPayloadType>>()
                .Argument("jobId", arg => arg.Type<NonNullType<UuidType>>())
                .Resolver(ctx =>
                {
                    var message = ctx.GetEventMessage<OnScrapeContextStepMessage>();
                    return message.Payload;
                });
            descriptor.Field("onScrapeContextComplete")
            .Description("A subscription for when a scrape context completes.")
               .Type<NonNullType<ScrapeContextCompletePayloadType>>()
               .Argument("jobId", arg => arg.Type<NonNullType<UuidType>>())
               .Resolver(ctx =>
               {
                   var message = ctx.GetEventMessage<OnScrapeContextCompleteMessage>();
                   return message.Payload;
               });
            descriptor.Field("onScrapeContextDelete")
                .Description("A subscription for when a scrape context is deleted.")
                .Type<NonNullType<DeleteScrapeContextPayloadType>>()
                .Argument("jobId", arg => arg.Type<NonNullType<UuidType>>())
                .Resolver(ctx =>
                {
                    var message = ctx.GetEventMessage<OnScrapeContextDeleteMessage>();
                    return message.Payload;
                });
            descriptor.Field("onScrapeContextCancel")
                .Description("A subscription for when a scrape context is cancelled.")
                .Type<NonNullType<CancelScrapeContextPayloadType>>()
                .Argument("jobId", arg => arg.Type<NonNullType<UuidType>>())
                .Resolver(ctx =>
                {
                    var message = ctx.GetEventMessage<OnScrapeContextCancelMessage>();
                    return message.Payload;
                });
            descriptor.Field("onScrapeContextApply")
                .Description("A subscription for when a scrape context is applied to a game.")
                .Type<NonNullType<ApplyScrapeContextPayloadType>>()
                .Argument("jobId", arg => arg.Type<NonNullType<UuidType>>())
                .Resolver(ctx =>
                {
                    var message = ctx.GetEventMessage<OnScrapeContextApplyMessage>();
                    return message.Payload;
                });
        }
    }
}
