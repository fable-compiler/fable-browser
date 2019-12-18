namespace Browser.Types

open System
open Fable.Core
open Fable.Core.JS
open Browser
open Browser.Types
open System.Collections.Generic

type RTCDtlsFingerprint =
    abstract algorithm: string option with get, set
    abstract value: string with get, set

type RTCCertificate =
    abstract expires: float
    abstract getFingerprints: unit -> RTCDtlsFingerprint array

type RTCCertificateType =
    abstract getSupportedAlgorithms: unit -> string array

[<StringEnum>]
type BinaryType =
| Blob
| Arraybuffer

[<StringEnum>]
type RTCDataChannelState =
| Connecting
| Open
| Closing
| Closed



type RTCDataChannel =
    inherit EventTarget
    abstract binaryType: BinaryType with get, set
    abstract bufferedAmount: uint32
    abstract bufferedAmountLowThreshold: uint32 with get, set
    abstract id: uint32
    abstract label: string
    abstract maxPacketLifeTime: uint32 option
    abstract maxRetransmits: uint32 option
    abstract negotiated: bool
    abstract ordered: bool
    abstract protocol: string
    abstract readyState: RTCDataChannelState

    abstract close: unit -> unit
    abstract send: data: U4<string, Blob, ArrayBuffer, ArrayBufferView> -> unit

    abstract onopen: (Event -> unit) with get, set
    abstract onmessage: (MessageEvent -> unit) with get, set
    abstract onbufferedamountlow: (Event -> unit) with get, set
    abstract onerror: (ErrorEvent -> unit) with get, set
    abstract onclose: (Event -> unit) with get, set

[<StringEnum>]
type RTCPriorityType =
| [<CompiledName("very-low")>] VeryLow
| Low
| Medium
| High

type RTCDataChannelInit =
    abstract ordered: bool with get, set
    abstract maxPacketLifeTime: uint32 option with get, set
    abstract maxRetransmits: uint32 option with get, set
    abstract protocol: string with get, set
    abstract negotiated: bool with get, set
    abstract id: uint32 option with get, set
    abstract priority: RTCPriorityType with get, set

type RTCDataChannelInitType =
    [<Emit("new Object({ordered:true,protocol:'',negotiated:false,priority:'low'})")>]
    abstract Create:unit -> RTCDataChannelInit

type RTCDataChannelEvent =
    inherit Event
    abstract channel: RTCDataChannel







[<StringEnum>]
type RTCIceCredentialType =
    | Password
    | Token

type RTCIceServer =
    abstract urls: U2<string, ResizeArray<string>> with get, set
    abstract credentialType: RTCIceCredentialType option with get, set
    abstract credential: string option with get, set
    abstract username: string option with get, set

type RTCIceServerType =
    [<Emit "new Object({urls: $1, username: $2, credential: $3, credentialType: $4})">]
    abstract Create: urls:string array * ?username:string * ?credential: string * ?credentialType: RTCIceCredentialType -> RTCIceServer

[<StringEnum>]
type RTCIceTransportComponent =
    | [<CompiledName("RTP")>] RTP
    | [<CompiledName("RTSP")>] RTSP

[<StringEnum>]
type RTCIceComponent =
    | [<CompiledName("rtp")>] RTP
    | [<CompiledName("rtcp")>] RTCP





type RTCOfferAnswerOptions =
    abstract voiceActivityDetection: bool option with get, set

type RTCOfferOptions =
    inherit RTCOfferAnswerOptions
    abstract iceRestart: bool option with get, set

type RTCAnswerOptions =
    inherit RTCOfferAnswerOptions

type RTCIceCandidateInit =
    abstract candidate: string with get, set
    abstract sdpMid: string option with get, set
    abstract sdpMLineIndex: uint16 option with get, set
    abstract usernameFragment: string option with get, set


type RTCIceParameters =
    abstract usernameFragment: string option with get, set
    abstract password: string option with get, set

[<StringEnum>]
type RTCIceGatheringState =
| New
| Gathering
| Complete

[<StringEnum>]
type RTCIceProtocol =
| [<CompiledName("udp")>] UDP
| [<CompiledName("tcp")>] TCP

[<StringEnum>]
type RTCIceTcpCandidateType =
| Active
| Passive
| [<CompiledName("so")>] SO


[<StringEnum>]
type RTCIceCandidateType =
| Host
| Srflx
| Prflx
| Relay

type RTCIceCandidate =
    abstract candidate: string
    abstract ``component``: RTCIceComponent
    abstract foundation: string
    abstract ip: string option
    abstract port: uint32
    abstract priority: uint32 option
    abstract protocol: RTCIceProtocol option
    abstract relatedAddress: string option
    abstract relatedPort: uint32 option

    abstract sdpMid: string option
    abstract sdpMLineIndex: uint32 option
    abstract tcpType: RTCIceTcpCandidateType option
    abstract ``type``: RTCIceCandidateType option
    abstract usernameFragment: string option

    abstract address: string option
    abstract toJSON : unit -> RTCIceCandidateInit

type RTCIceCandidateInitType =
    [<Emit("new Object({candidate:$1,sdpMid:$2,sdpMLineIndex:$3{{,usernameFragment:$4}}})")>]
    abstract Create: candidate:string * sdpMid:string * sdpMLineIndex:string * ?usernameFragment:string -> RTCIceCandidateInit

type RTCIceCandidateStaticType =
    abstract candidate: string with get, set
    abstract sdpMid: string with get, set
    abstract sdpMLineIndex: uint16 with get, set
    abstract usernameFragment: string option with get, set

    [<Emit("new $0($1...)")>] abstract Create: RTCIceCandidateInit option -> RTCIceCandidate

type RTCIceCandidatePair =
    abstract local: RTCIceCandidate  with get, set
    abstract remote: RTCIceCandidate with get, set

[<StringEnum>]
type RoleType =
    | Controlling
    | Controlled

[<StringEnum>]
type RTCIceTransportState =
| New //The RTCIceTransport is currently gathering local candidates, or is waiting for the remote device to begin to transmit the remote candidates, or both. In this state, checking of candidates to look for those which might be acceptable has not yet begun.
| Checking //At least one remote candidate has been received, and the RTCIceTransport has begun examining pairings of remote and local candidates in order to attempt to identify viable pairs that could be used to establish a connection. Keep in mind that gathering of local candidates may still be underway, and, similarly, the remote device also may still be gathering candidates of its own.
| Connected //A viable candidate pair has been found and selected, and the RTCIceTransport has connected the two peers together using that pair. However, there are still candidates pairings to consider, and there may still be gathering underway on one or both of the two devices.
//The transport may revert from the "connected" state to the "checking" state if either peer decides to cancel consent to use the selected candidate pair, and may revert to "disconnected" if there are no candidates left to check but one or both clients are still gathering candidates.
| Completed //The transport has finished gathering local candidates and has received a notification from the remote peer that no more candidates will be sent. In addition, all candidate pairs have been considered and a pair has been selected for use. If consent checks fail on all successful candidate pairs, the transport state will change to "failed".
| Disconnected //The ICE agent has determined that connectivity has been lost for this RTCIceTransport. This is not a failure state (that's "failed"). A value of "disconnected" means that a transient issue has occurred that has broken the connection, but that should resolve itself automatically without your code having to take any action. See The disconnected state for additional details.
| Failed //The RTCIceTransport has finished the gathering process, has received the "no more candidates" notification from the remote peer, and has finished checking pairs of candidates, without successfully finding a pair that is both valid and for which consent can be obtained. This is a terminal state, indicating that the connection cannot be achieved or maintained.
| Closed //The transport has shut down and is no int64er responding to STUN requests.

type RTCIceTransport =
    inherit EventTarget
    abstract ``component``: RTCIceTransportComponent
    abstract gatheringState: RTCIceGatheringState
    abstract role: RoleType
    abstract state: RTCIceTransportState

    abstract getLocalCandidates: unit -> RTCIceCandidate array
    abstract getLocalParameters: unit -> RTCIceParameters option

    abstract getRemoteCandidates: unit -> RTCIceCandidate array
    abstract getRemoteParameters: unit -> RTCIceParameters option

    abstract getSelectedCandidatePair: unit -> RTCIceCandidatePair option

    abstract onstatechange: (Event -> unit) with get, set
    abstract ongatheringstatechange: (Event -> unit) with get, set
    abstract onselectedcandidatepairchange: (Event -> unit) with get, set

[<StringEnum>]
type RTCDtlsTransportState =
| New
| Connecting
| Connected
| Closed
| Failed

type RTCDtlsTransport =
    inherit EventTarget
    abstract state: RTCDtlsTransportState
    abstract iceTransport: RTCIceTransport
    abstract getRemoteCertificates: unit -> ResizeArray<ArrayBuffer>
    abstract onstatechange: (Event -> unit) with get, set
    abstract onerror: (Event -> unit) with get, set



type RTCRtpContributingSource =
    abstract audioLevel: float option
    abstract uint32: float
    abstract timestamp: float


[<StringEnum>]
type RTCDegradationPreference =
| [<CompiledName("maintain-framerate")>] MaintainFramerate
| [<CompiledName("maintain-resolution")>] MaintainResolution
| [<CompiledName("balanced")>] Balanced


type RTCRtpCodingParameters =
    abstract rid: string

type RTCRtpDecodingParameters =
    inherit RTCRtpCodingParameters

type RTCRtpHeaderExtensionParameters =
    abstract uri: string
    abstract id: uint32
    abstract encrypted: bool

type RTCRtcpParameters =
    abstract cname: string
    abstract reducedSize: bool

type RTCRtpCodecParameters =
    abstract payloadType: uint32
    abstract mimeType: string
    abstract clockRate: uint32
    abstract channels: uint32
    abstract sdpFmtpLine: string

type RTCRtpParameters =
    abstract headerExtensions: ResizeArray<RTCRtpHeaderExtensionParameters>
    abstract rtcp: RTCRtcpParameters
    abstract codecs: ResizeArray<RTCRtpCodecParameters>

type RTCRtpReceiveParameters =
    inherit RTCRtpParameters
    abstract encodings: ResizeArray<RTCRtpDecodingParameters>

type RTCRtpSynchronizationSource =
    inherit RTCRtpContributingSource
    abstract voiceActivityFlag: bool

[<StringEnum>]
type RTCStatsType =
| Codec
| [<CompiledName("inbound-rtp")>] InboundRtp
| [<CompiledName("outbound-rtp")>] OutboundRtp
| [<CompiledName("remote-inbound-rtp")>] RemoteInboundRtp
| [<CompiledName("remote-outbound-rtp")>] RemoteOutboundRtp
| Csrc
| [<CompiledName("peer-connection")>]  PeerConnection
| [<CompiledName("data-channel")>]  DataChannel
| Stream
| Track
| Sender
| Receiver
| Transport
| [<CompiledName("candidate-pair")>] CandidatePair
| [<CompiledName("local-candidate")>] LocalCandidate
| [<CompiledName("remote-candidate")>] RemoteCandidate
| Certificate

type RTCStats =
    abstract timestamp: double
    abstract ``type``: RTCStatsType
    abstract id: string

[<StringEnum>]
type RTCCodecType =
| Encode
| Decode

type  RTCCodecStats =
    inherit RTCStats
    abstract payloadType: uint32
    abstract codecType:  RTCCodecType
    abstract transportId: string
    abstract mimeType: string
    abstract clockRate: uint32
    abstract channels: uint32
    abstract sdpFmtpLine: string
    abstract implementation: string

type RTCRtpStreamStats =
    inherit RTCStats
    abstract ssrc: uint32
    abstract kind: string
    abstract transportId: string
    abstract codecId: string
    abstract firCount: uint32
    abstract pliCount: uint32
    abstract nackCount: uint32
    abstract sliCount: uint32
    abstract qpSum: uint32

type RTCReceivedRtpStreamStats =
    inherit RTCRtpStreamStats
    abstract packetsReceived: uint32
    abstract packetsLost: int64
    abstract jitter: float
    abstract packetsDiscarded: uint32
    abstract packetsRepaired: uint32
    abstract burstPacketsLost: uint32
    abstract burstPacketsDiscarded: uint32
    abstract burstLossCount: uint32
    abstract burstDiscardCount: uint32
    abstract burstLossRate: float
    abstract burstDiscardRate: float
    abstract gapLossRate: float
    abstract gapDiscardRate: float

type RTCInboundRtpStreamStats =
    inherit RTCReceivedRtpStreamStats
    abstract trackId: string
    abstract receiverId: string
    abstract remoteId: string
    abstract framesDecoded: uint32
    abstract lastPacketReceivedTimestamp: float
    abstract averageRtcpInterval: float
    abstract fecPacketsReceived:  uint32
    abstract bytesReceived: uint32
    abstract packetsFailedDecryption:  uint32
    abstract packetsDuplicated: uint32
    abstract perDscpPacketsReceived: Dictionary<string, uint32>

type RTCSentRtpStreamStats =
    inherit RTCRtpStreamStats
    abstract packetsSent: uint32
    abstract packetsDiscardedOnSend: uint32
    abstract fecPacketsSent: uint32
    abstract bytesSent: uint32
    abstract bytesDiscardedOnSend: uint32

[<StringEnum>]
type RTCQualityLimitationReason =
| [<CompiledName("none")>] None'
| Cpu
| Bandwidth
| Other

type RTCOutboundRtpStreamStats =
    inherit RTCSentRtpStreamStats
    abstract trackId: string
    abstract senderId: string
    abstract remoteId: string
    abstract lastPacketSentTimestamp: float
    abstract targetBitrate: float
    abstract framesEncoded: uint32
    abstract totalEncodeTime: float
    abstract averageRtcpInterval: float
    abstract qualityLimitationReason: RTCQualityLimitationReason
    abstract qualityLimitationDurations: Dictionary<string, float>
    abstract perDscpPacketsSent: Dictionary<string, uint32>

type RTCRemoteInboundRtpStreamStats =
    inherit RTCReceivedRtpStreamStats
    abstract localId: string
    abstract roundTripTime: float
    abstract fractionLost: float

type RTCRemoteOutboundRtpStreamStats =
    inherit RTCSentRtpStreamStats
    abstract localId: string
    abstract remoteTimestamp: float

type RTCRtpContributingSourceStats =
    inherit RTCStats
    abstract contributorSsrc: uint32
    abstract inboundRtpStreamId: string
    abstract packetsContributedTo: uint32
    abstract audioLevel: float

type RTCPeerConnectionStats =
    inherit RTCStats
    abstract dataChannelsOpened: uint32
    abstract dataChannelsClosed: uint32
    abstract dataChannelsRequested: uint32
    abstract dataChannelsAccepted: uint32

type RTCDataChannelStats =
    inherit RTCStats
    abstract label: string
    abstract protocol: string
    abstract dataChannelIdentifier: int64
    abstract transportId: string
    abstract state: RTCDataChannelState
    abstract messagesSent: uint32
    abstract bytesSent: uint32
    abstract messagesReceived: uint32
    abstract bytesReceived: uint32

type RTCMediaStreamStats =
    inherit RTCStats
    abstract streamIdentifier: string
    abstract trackIds: ResizeArray<string>

type RTCMediaHandlerStats =
    inherit RTCStats
    abstract trackIdentifier: string
    abstract remoteSource: bool
    abstract ended: bool
    abstract kind: string
    abstract priority: RTCPriorityType

type RTCVideoHandlerStats =
    inherit RTCMediaHandlerStats
    abstract frameWidth: uint32
    abstract frameHeight: uint32
    abstract framesPerSecond: float

type RTCVideoSenderStats =
    inherit RTCVideoHandlerStats
    abstract framesCaptured: uint32
    abstract framesSent: uint32
    abstract hugeFramesSent: uint32
    abstract keyFramesSent: uint32

type RTCSenderVideoTrackAttachmentStats  =
    inherit RTCVideoSenderStats

type RTCAudioHandlerStats =
    inherit RTCMediaHandlerStats
    abstract audioLevel: float
    abstract totalAudioEnergy: float
    abstract voiceActivityFlag: bool
    abstract totalSamplesDuration: float

type RTCAudioSenderStats =
    inherit RTCAudioHandlerStats
    abstract echoReturnLoss: float
    abstract echoReturnLossEnhancement: float
    abstract totalSamplesSent: uint32

type RTCSenderAudioTrackAttachmentStats =
    inherit RTCAudioSenderStats

type RTCAudioReceiverStats =
    inherit RTCAudioHandlerStats
    abstract estimatedPlayoutTimestamp: float
    abstract jitterBufferDelay: float
    abstract jitterBufferEmittedCount: uint32
    abstract totalSamplesReceived: uint32
    abstract concealedSamples: uint32
    abstract concealmentEvents: uint32

type RTCVideoReceiverStats =
    inherit RTCVideoHandlerStats
    abstract estimatedPlayoutTimestamp: float
    abstract jitterBufferDelay: float
    abstract jitterBufferEmittedCount: uint32
    abstract framesReceived: uint32
    abstract keyFramesReceived: uint32
    abstract framesDecoded: uint32
    abstract framesDropped: uint32
    abstract partialFramesLost: uint32
    abstract fullFramesLost: uint32

type RTCIceRole = obj
type RTCTransportStats =
    inherit RTCStats
    abstract packetsSent:uint32
    abstract packetsReceived:uint32
    abstract bytesSent:uint32
    abstract bytesReceived:uint32
    abstract rtcpTransportStatsId: string
    abstract iceRole: RTCIceRole
    abstract dtlsState: RTCDtlsTransportState
    abstract selectedCandidatePairId: string
    abstract localCertificateId: string
    abstract remoteCertificateId: string
    abstract dtlsCipher: string
    abstract srtpCipher: string

[<StringEnum>]
type RTCStatsIceCandidatePairState =
| Frozen
| Waiting
| [<CompiledName("in-progress")>] InProgress
| Failed
| Succeeded

type RTCIceCandidatePairStats =
    inherit RTCStats
    abstract transportId: string
    abstract localCandidateId: string
    abstract remoteCandidateId: string
    abstract state: RTCStatsIceCandidatePairState ;
    abstract nominated: bool
    abstract packetsSent: uint32
    abstract packetsReceived: uint32
    abstract bytesSent: uint32
    abstract bytesReceived: uint32
    abstract lastPacketSentTimestamp: float
    abstract lastPacketReceivedTimestamp: float
    abstract firstRequestTimestamp: float
    abstract lastRequestTimestamp: float
    abstract lastResponseTimestamp: float
    abstract totalRoundTripTime: float
    abstract currentRoundTripTime: float
    abstract availableOutgoingBitrate: float
    abstract availableIncomingBitrate: float
    abstract circuitBreakerTriggerCount: uint32
    abstract requestsReceived: uint32
    abstract requestsSent: uint32
    abstract responsesReceived: uint32
    abstract responsesSent: uint32
    abstract retransmissionsReceived: uint32
    abstract retransmissionsSent: uint32
    abstract consentRequestsSent: uint32
    abstract consentExpiredTimestamp: float

[<StringEnum>]
type RTCNetworkType =
| Bluetooth
| Cellular
| Ethernet
| Wifi
| Wimax
| Vpn
| Unknown

type RTCIceCandidateStats =
    inherit RTCStats
    abstract transportId: string
    abstract networkType: RTCNetworkType
    abstract ip: string
    abstract port: int64
    abstract protocol: string
    abstract candidateType: RTCIceCandidateType
    abstract priority: int64
    abstract url: string
    abstract relayProtocol: string
    abstract deleted: bool

type RTCCertificateStats =
    inherit RTCStats
    abstract fingerprint: string
    abstract fingerprintAlgorithm: string
    abstract base64Certificate: string
    abstract issuerCertificateId: string

type RTCStatsReport = System.Collections.Generic.Dictionary<string,RTCStats>

type RTCRtpReceiver =
    abstract track: MediaStreamTrack
    abstract rtcpTransport: RTCDtlsTransport option
    abstract transport: RTCDtlsTransport option

    abstract getContributingSources: unit -> ResizeArray<RTCRtpContributingSource>
    abstract getSynchronizationSources: unit -> ResizeArray<RTCRtpSynchronizationSource>

    abstract getParameters: unit -> RTCRtpReceiveParameters
    abstract getStats: unit -> JS.Promise<RTCStatsReport>

type RTCRtpCodecCapability =
  abstract mimeType: string
  abstract clockRate: uint32
  abstract channels: uint32
  abstract sdpFmtpLine: string

type RTCRtpHeaderExtensionCapability =
  abstract uri: string

type RTCRtpCapabilities =
  abstract codecs: ResizeArray<RTCRtpCodecCapability>
  abstract headerExtensions: ResizeArray<RTCRtpHeaderExtensionCapability>

type RTCRtpReceiverType =
    [<Emit("RTCRtpReceiver.getCapabilities($1)")>]
    abstract getCapabilities: kind:string -> RTCRtpCapabilities option

[<StringEnum>]
type RTCDtxStatus =
| Disabled
| Enabled

type RTCRtpEncodingParameters =
    inherit RTCRtpCodingParameters
    abstract codecPayloadType: uint32 option with get, set
    abstract dtx: RTCDtxStatus option with get, set
    abstract active: bool with get, set
    abstract ptime: uint32 option with get, set
    abstract maxBitrate: uint32 option with get, set
    abstract maxFramerate: float option with get, set
    abstract scaleResolutionDownBy: float option with get, set
    abstract priority: RTCPriorityType with get, set

type RTCRtpSendParameters =
    inherit RTCRtpParameters
    abstract transactionId:string
    abstract encodings: ResizeArray<RTCRtpEncodingParameters> with get, set
    abstract degradationPreference: RTCDegradationPreference option with get, set

type RTCRtpSender =
    //TODO: abstract dtmf: obj
    abstract rtcpTransport: RTCDtlsTransport option
    abstract transport: RTCDtlsTransport option

    abstract track: MediaStreamTrack option

    abstract setParameters: parameters:RTCRtpSendParameters -> JS.Promise<unit>
    abstract getParameters: unit -> RTCRtpSendParameters
    abstract replaceTrack: withTrack:#MediaStreamTrack option -> JS.Promise<unit>

    [<Emit("$0.setStreams($1...)")>]
    abstract setStreams: [<ParamArray>] streams:MediaStream [] -> unit
    abstract getStates: unit -> JS.Promise<RTCStatsReport>

type RTCRtpSenderType =
    [<Emit("RTCRtpSender.getCapabilities($1)")>]
    abstract getCapabilities: kind:string -> RTCRtpCapabilities option


[<StringEnum>]
type RTCRtpTransceiverDirection =
| [<CompiledName("sendrecv")>] SendRecv
| [<CompiledName("sendonly")>] SendOnly
| [<CompiledName("recvonly")>] RecvOnly
| [<CompiledName("inactive")>] Inactive


type RTCRtpTransceiver =
    abstract mid: string option
    abstract sender: RTCRtpSender
    abstract receiver: RTCRtpReceiver
    abstract direction: RTCRtpTransceiverDirection with get, set
    abstract currentDirection: RTCRtpTransceiverDirection
    abstract stop: unit -> unit
    abstract setCodecPreferences: codecs: ResizeArray<RTCRtpCodecParameters> -> unit

[<StringEnum>]
type RTCSctpTransportState =
| Connecting
| Connected
| Closed

type RTCSctpTransport =
    inherit EventTarget
    abstract transport: RTCDtlsTransport
    abstract state: RTCSctpTransportState
    abstract maxMessageSize: float
    abstract maxChannels: uint32 option
    abstract onstatechange: (Event -> unit) with get, set

[<StringEnum>]
type RTCSdpType =
| Offer // An RTCSdpType of offer indicates that a description MUST be treated as an [SDP] offer.
| [<CompiledName("pranswer")>] PRAnswer //An RTCSdpType of pranswer indicates that a description MUST be treated as an [SDP] answer, but not a final answer. A description used as an SDP pranswer may be applied as a response to an SDP offer, or an update to a previously sent SDP pranswer.
| Answer //An RTCSdpType of answer indicates that a description MUST be treated as an [SDP] final answer, and the offer-answer exchange MUST be considered complete. A description used as an SDP answer may be applied as a response to an SDP offer or as an update to a previously sent SDP pranswer.
| Rollback // An RTCSdpType of rollback indicates that a description MUST be treated as canceling the current SDP negotiation and moving the SDP [SDP] offer and answer back to what it was in the previous stable state. Note the local or remote SDP descriptions in the previous stable state could be null if there has not yet been a successful offer-answer negotiation.

type RTCSessionDescriptionInit =
    abstract ``type``: RTCSdpType with get, set
    abstract sdp: string with get, set

type RTCSessionDescriptionInitType =
    [<Emit "({type:$1, sdp:$2})">] abstract Create: ``type``:RTCSdpType * sdp:string  -> RTCSessionDescriptionInit

type RTCSessionDescription =
    abstract ``type``: RTCSdpType
    abstract sdp: string
    abstract toJSON: unit -> RTCSessionDescriptionInit


type RTCSessionDescriptionType =
    [<Emit "new $0($1...)">] abstract Create: ?message: RTCSessionDescriptionInit -> RTCSessionDescription
    [<Emit "new $0({sdp:$1})">] abstract Create: sdp: string -> RTCSessionDescription


type RTCPeerConnectionIceEvent =
    inherit Event
    abstract candidate: RTCIceCandidate option
    abstract url: string option

type RTCPeerConnectionIceErrorEvent =
    inherit Event
    abstract hostCandidate: string
    abstract url: string
    abstract errorCode: uint32
    abstract errorText: string

[<StringEnum>]
type RTCSignalingState =
| Stable
| [<CompiledName("have-local-offer")>] HaveLocalOffer
| [<CompiledName("have-remote-offer")>] HaveRemoteOffer
| [<CompiledName("have-local-pranswer")>] HaveLocalPRAnswer
| [<CompiledName("have-remote-pranswer")>] HaveRemotePRAnswer
| Closed

[<StringEnum>]
type RTCIceConnectionState =
| Closed
| Failed
| Disconnected
| New
| Checking
| Completed
| Connected

[<StringEnum>]
type RTCPeerConnectionState =
| Closed
| Failed
| Disconnected
| New
| Connecting
| Connected

[<StringEnum>]
type RTCIceTransportPolicy =
| All // All ICE candidates will be considered.
| Public // Only ICE candidates with public IP addresses will be considered. Removed from the specification's May 13, 2016 working draft
| Relay // Only ICE candidates whose IP addresses are being relayed, such as those being passed through a TURN server, will be considered.

[<StringEnum>]
type RTCBundlePolicy =
| Balance // On BUNDLE-aware connections, the ICE agent should gather candidates for all of the media types in use (audio, video, and data). Otherwise, the ICE agent should only negotiate one audio and video track on separate transports.
| [<CompiledName("max-compat")>] MaxCompat // The ICE agent should gather candidates for each track, using separate transports to negotiate all media tracks for connections which aren't BUNDLE-compatible.
| [<CompiledName("max-bundle")>] MaxBundle // The ICE agent should gather candidates for just one track. If the connection isn't BUNDLE-compatible, then the ICE agent should negotiate just one media track.


[<StringEnum>]
type RTCRtcpMuxPolicy =
| Negotiate //Instructs the ICE agent to gather both RTP and RTCP candidates. If the remote peer can multiplex RTCP, then RTCP candidates are multiplexed atop the corresponding RTP candidates. Otherwise, both the RTP and RTCP candidates are returned, separately.
| Require //Tells the ICE agent to gather ICE candidates for only RTP, and to multiplex RTCP atop them. If the remote peer doesn't support RTCP multiplexing, then session negotiation fails.

type RTCConfiguration =
    abstract iceServers: ResizeArray<RTCIceServer> option with get, set
    abstract iceTransportPolicy: RTCIceTransportPolicy option with get, set
    abstract bundlePolicy: RTCBundlePolicy option with get, set
    abstract rtcpMuxPolicy: RTCRtcpMuxPolicy option with get, set
    abstract peerIdentity: string option with get, set
    abstract certificates: ResizeArray<RTCCertificate> option with get, set
    abstract iceCandidatePoolSize: uint32 option with get, set

type RTCTrackEvent =
    inherit Event
    abstract receiver: RTCRtpReceiver
    abstract track: MediaStreamTrack
    abstract streams: MediaStream array
    abstract transceiver: RTCRtpTransceiver

type RTCRtpTransceiverInit =
    abstract direction: RTCRtpTransceiverDirection option
    abstract sendEncodings: RTCRtpEncodingParameters array option
    abstract streams: MediaStream array option

type RTCPeerConnection =
    inherit EventTarget
    abstract onnegotiationneeded: (Event->unit) with get,set
    abstract onicecandidate: (RTCPeerConnectionIceEvent->unit) with get,set
    abstract onicecandidateerror: (RTCPeerConnectionIceErrorEvent->unit) with get,set
    abstract onsignalingstatechange: (Event->unit) with get,set
    abstract oniceconnectionstatechange: (Event->unit) with get,set
    abstract onicegatheringstatechange: (Event->unit) with get,set
    abstract onconnectionstatechange: (Event->unit) with get,set

    abstract localDescription: RTCSessionDescription option
    abstract currentLocalDescription: RTCSessionDescription option
    abstract pendingLocalDescription: RTCSessionDescription option
    abstract remoteDescription: RTCSessionDescription option
    abstract currentRemoteDescription: RTCSessionDescription option
    abstract pendingRemoteDescription: RTCSessionDescription option
    abstract signalingState: RTCSignalingState
    abstract iceGatheringState: RTCIceGatheringState
    abstract iceConnectionState: RTCIceConnectionState
    abstract connectionState: RTCPeerConnectionState
    abstract canTrickleIceCandidates: bool option

    abstract createOffer: ?options:RTCOfferOptions -> JS.Promise<RTCSessionDescriptionInit>
    abstract createAnswer: ?options:RTCAnswerOptions -> JS.Promise<RTCSessionDescriptionInit>
    abstract setLocalDescription: description:RTCSessionDescriptionInit -> JS.Promise<unit>
    abstract setRemoteDescription: description:RTCSessionDescriptionInit -> JS.Promise<unit>
    abstract addIceCandidate: candidate:RTCIceCandidateInit-> JS.Promise<unit>

    abstract restartIce: unit -> unit
    abstract getConfiguration: unit -> RTCConfiguration
    abstract setConfiguration: configuration:RTCConfiguration -> unit
    abstract close: unit -> unit

    abstract getSenders: unit -> ResizeArray<RTCRtpSender>
    abstract getReceivers: unit -> ResizeArray<RTCRtpReceiver>
    abstract getTransceivers: unit -> ResizeArray<RTCRtpTransceiver>

    [<Emit("$0.addTrack($1,$2...)")>]
    abstract addTrack: track:MediaStreamTrack * [<ParamArray>] streams: MediaStream array -> RTCRtpSender

    abstract removeTrack: sender:RTCRtpSender -> unit

    abstract addTransceiver: track:MediaStreamTrack * ?init: RTCRtpTransceiverInit -> RTCRtpTransceiver
    abstract addTransceiver: trackKind:TrackKind -> RTCRtpTransceiver
    abstract ontrack: (RTCTrackEvent->unit) with get,set

    abstract sctp: RTCSctpTransport option
    abstract ondatachannel: (RTCDataChannelEvent -> unit) with get, set
    abstract createDataChannel: label: string* ?dataChannelInit:RTCDataChannelInit -> RTCDataChannel

type RTCPeerConnectionType =
    abstract getDefaultIceServers: unit -> ResizeArray<RTCIceServer>
    [<Emit "new $0($1...)">]
    abstract Create: ?configuration: RTCConfiguration -> RTCPeerConnection

type RTCConfigurationType =
    [<Emit "new Object({iceServers: $1})">]
    abstract Create: iceServers: RTCIceServer [] -> RTCConfiguration

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module WebRTC =
    let [<Global>] RTCPeerConnection: RTCPeerConnectionType = jsNative
    let [<Global>] RTCIceCandidate: RTCIceCandidateStaticType = jsNative
    let [<Global>] RTCIceCandidateInit: RTCIceCandidateInitType = jsNative
    let [<Global>] RTCRtpReceiver: RTCRtpReceiverType = jsNative
    let [<Global>] RTCRtpSender: RTCRtpSenderType = jsNative
    let [<Global>] RTCSessionDescription: RTCSessionDescriptionType = jsNative
    let [<Global>] RTCSessionDescriptionInit: RTCSessionDescriptionInitType = jsNative
    let [<Global>] RTCConfiguration: RTCConfigurationType = jsNative
    let [<Global>] RTCIceServer: RTCIceServerType = jsNative

    let [<Global>] RTCDataChannelInit: RTCDataChannelInitType = jsNative