using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the cloudCommunications singleton.</summary>
    public class Call : Entity, IParsable {
        /// <summary>Read-only. Nullable.</summary>
        public List<AudioRoutingGroup> AudioRoutingGroups {
            get { return BackingStore?.Get<List<AudioRoutingGroup>>(nameof(AudioRoutingGroups)); }
            set { BackingStore?.Set(nameof(AudioRoutingGroups), value); }
        }
        /// <summary>The callback URL on which callbacks will be delivered. Must be https.</summary>
        public string CallbackUri {
            get { return BackingStore?.Get<string>(nameof(CallbackUri)); }
            set { BackingStore?.Set(nameof(CallbackUri), value); }
        }
        /// <summary>A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.</summary>
        public string CallChainId {
            get { return BackingStore?.Get<string>(nameof(CallChainId)); }
            set { BackingStore?.Set(nameof(CallChainId), value); }
        }
        /// <summary>Contains the optional features for the call.</summary>
        public Microsoft.Graph.Models.CallOptions CallOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CallOptions>(nameof(CallOptions)); }
            set { BackingStore?.Set(nameof(CallOptions), value); }
        }
        /// <summary>The routing information on how the call was retargeted. Read-only.</summary>
        public List<CallRoute> CallRoutes {
            get { return BackingStore?.Get<List<CallRoute>>(nameof(CallRoutes)); }
            set { BackingStore?.Set(nameof(CallRoutes), value); }
        }
        /// <summary>The chat information. Required information for meeting scenarios.</summary>
        public Microsoft.Graph.Models.ChatInfo ChatInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ChatInfo>(nameof(ChatInfo)); }
            set { BackingStore?.Set(nameof(ChatInfo), value); }
        }
        /// <summary>The direction of the call. The possible value are incoming or outgoing. Read-only.</summary>
        public CallDirection? Direction {
            get { return BackingStore?.Get<CallDirection?>(nameof(Direction)); }
            set { BackingStore?.Set(nameof(Direction), value); }
        }
        /// <summary>The context associated with an incoming call. Read-only. Server generated.</summary>
        public Microsoft.Graph.Models.IncomingContext IncomingContext {
            get { return BackingStore?.Get<Microsoft.Graph.Models.IncomingContext>(nameof(IncomingContext)); }
            set { BackingStore?.Set(nameof(IncomingContext), value); }
        }
        /// <summary>The media configuration. Required information for creating peer to peer calls or joining meetings.</summary>
        public Microsoft.Graph.Models.MediaConfig MediaConfig {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MediaConfig>(nameof(MediaConfig)); }
            set { BackingStore?.Set(nameof(MediaConfig), value); }
        }
        /// <summary>Read-only. The call media state.</summary>
        public CallMediaState MediaState {
            get { return BackingStore?.Get<CallMediaState>(nameof(MediaState)); }
            set { BackingStore?.Set(nameof(MediaState), value); }
        }
        /// <summary>The meeting information. Required information for meeting scenarios.</summary>
        public Microsoft.Graph.Models.MeetingInfo MeetingInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.MeetingInfo>(nameof(MeetingInfo)); }
            set { BackingStore?.Set(nameof(MeetingInfo), value); }
        }
        /// <summary>The myParticipantId property</summary>
        public string MyParticipantId {
            get { return BackingStore?.Get<string>(nameof(MyParticipantId)); }
            set { BackingStore?.Set(nameof(MyParticipantId), value); }
        }
        /// <summary>Read-only. Nullable.</summary>
        public List<CommsOperation> Operations {
            get { return BackingStore?.Get<List<CommsOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>Read-only. Nullable.</summary>
        public List<Participant> Participants {
            get { return BackingStore?.Get<List<Participant>>(nameof(Participants)); }
            set { BackingStore?.Set(nameof(Participants), value); }
        }
        /// <summary>The requestedModalities property</summary>
        public List<string> RequestedModalities {
            get { return BackingStore?.Get<List<string>>(nameof(RequestedModalities)); }
            set { BackingStore?.Set(nameof(RequestedModalities), value); }
        }
        /// <summary>The resultInfo property</summary>
        public Microsoft.Graph.Models.ResultInfo ResultInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ResultInfo>(nameof(ResultInfo)); }
            set { BackingStore?.Set(nameof(ResultInfo), value); }
        }
        /// <summary>The source property</summary>
        public ParticipantInfo Source {
            get { return BackingStore?.Get<ParticipantInfo>(nameof(Source)); }
            set { BackingStore?.Set(nameof(Source), value); }
        }
        /// <summary>The state property</summary>
        public CallState? State {
            get { return BackingStore?.Get<CallState?>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>The subject property</summary>
        public string Subject {
            get { return BackingStore?.Get<string>(nameof(Subject)); }
            set { BackingStore?.Set(nameof(Subject), value); }
        }
        /// <summary>The targets property</summary>
        public List<InvitationParticipantInfo> Targets {
            get { return BackingStore?.Get<List<InvitationParticipantInfo>>(nameof(Targets)); }
            set { BackingStore?.Set(nameof(Targets), value); }
        }
        /// <summary>The tenantId property</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>The toneInfo property</summary>
        public Microsoft.Graph.Models.ToneInfo ToneInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ToneInfo>(nameof(ToneInfo)); }
            set { BackingStore?.Set(nameof(ToneInfo), value); }
        }
        /// <summary>The transcription information for the call. Read-only.</summary>
        public CallTranscriptionInfo Transcription {
            get { return BackingStore?.Get<CallTranscriptionInfo>(nameof(Transcription)); }
            set { BackingStore?.Set(nameof(Transcription), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Call CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Call();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"audioRoutingGroups", n => { AudioRoutingGroups = n.GetCollectionOfObjectValues<AudioRoutingGroup>(AudioRoutingGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                {"callChainId", n => { CallChainId = n.GetStringValue(); } },
                {"callOptions", n => { CallOptions = n.GetObjectValue<Microsoft.Graph.Models.CallOptions>(Microsoft.Graph.Models.CallOptions.CreateFromDiscriminatorValue); } },
                {"callRoutes", n => { CallRoutes = n.GetCollectionOfObjectValues<CallRoute>(CallRoute.CreateFromDiscriminatorValue).ToList(); } },
                {"chatInfo", n => { ChatInfo = n.GetObjectValue<Microsoft.Graph.Models.ChatInfo>(Microsoft.Graph.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                {"direction", n => { Direction = n.GetEnumValue<CallDirection>(); } },
                {"incomingContext", n => { IncomingContext = n.GetObjectValue<Microsoft.Graph.Models.IncomingContext>(Microsoft.Graph.Models.IncomingContext.CreateFromDiscriminatorValue); } },
                {"mediaConfig", n => { MediaConfig = n.GetObjectValue<Microsoft.Graph.Models.MediaConfig>(Microsoft.Graph.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                {"mediaState", n => { MediaState = n.GetObjectValue<CallMediaState>(CallMediaState.CreateFromDiscriminatorValue); } },
                {"meetingInfo", n => { MeetingInfo = n.GetObjectValue<Microsoft.Graph.Models.MeetingInfo>(Microsoft.Graph.Models.MeetingInfo.CreateFromDiscriminatorValue); } },
                {"myParticipantId", n => { MyParticipantId = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<CommsOperation>(CommsOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"participants", n => { Participants = n.GetCollectionOfObjectValues<Participant>(Participant.CreateFromDiscriminatorValue).ToList(); } },
                {"requestedModalities", n => { RequestedModalities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"resultInfo", n => { ResultInfo = n.GetObjectValue<Microsoft.Graph.Models.ResultInfo>(Microsoft.Graph.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                {"source", n => { Source = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<CallState>(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"targets", n => { Targets = n.GetCollectionOfObjectValues<InvitationParticipantInfo>(InvitationParticipantInfo.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"toneInfo", n => { ToneInfo = n.GetObjectValue<Microsoft.Graph.Models.ToneInfo>(Microsoft.Graph.Models.ToneInfo.CreateFromDiscriminatorValue); } },
                {"transcription", n => { Transcription = n.GetObjectValue<CallTranscriptionInfo>(CallTranscriptionInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AudioRoutingGroup>("audioRoutingGroups", AudioRoutingGroups);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteStringValue("callChainId", CallChainId);
            writer.WriteObjectValue<Microsoft.Graph.Models.CallOptions>("callOptions", CallOptions);
            writer.WriteCollectionOfObjectValues<CallRoute>("callRoutes", CallRoutes);
            writer.WriteObjectValue<Microsoft.Graph.Models.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteEnumValue<CallDirection>("direction", Direction);
            writer.WriteObjectValue<Microsoft.Graph.Models.IncomingContext>("incomingContext", IncomingContext);
            writer.WriteObjectValue<Microsoft.Graph.Models.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteObjectValue<CallMediaState>("mediaState", MediaState);
            writer.WriteObjectValue<Microsoft.Graph.Models.MeetingInfo>("meetingInfo", MeetingInfo);
            writer.WriteStringValue("myParticipantId", MyParticipantId);
            writer.WriteCollectionOfObjectValues<CommsOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Participant>("participants", Participants);
            writer.WriteCollectionOfPrimitiveValues<string>("requestedModalities", RequestedModalities);
            writer.WriteObjectValue<Microsoft.Graph.Models.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteObjectValue<ParticipantInfo>("source", Source);
            writer.WriteEnumValue<CallState>("state", State);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfObjectValues<InvitationParticipantInfo>("targets", Targets);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<Microsoft.Graph.Models.ToneInfo>("toneInfo", ToneInfo);
            writer.WriteObjectValue<CallTranscriptionInfo>("transcription", Transcription);
        }
    }
}
