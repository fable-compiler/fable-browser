### 1.3.1

* Add licence to Nuget package @nojaf

### 1.3.0

* Add more stat properties to `RTCInboundRtpStreamStats` and `RTCOutboundRtpStreamStats`
* Add `SdpSemantics` enum
* `RTCIceCandidateStats.relayProtocol` accepts only `tcp`/`tls` or `udp` so it could be specified as `RTCRelayProtocol` instead of a string. @MNie

### 1.2.0

* update `RTCIceCredentialType` prior [RFC 7635](https://tools.ietf.org/html/rfc7635) from `token` to `oauth`.

### 1.1.0

* `RTCIceCandidateStats.protocol` accepts only `udp` or `tcp` so it could be specified as `RTCIceProtocol` instead of a string. @MNie

### 1.0.1

* Fix `RTCRtpReceiver.getStates` should be a `RTCRtpReceiver.getStats`

### 1.0.0

* First stable release
* Fix `RTCIceCandidate.ip` as string option
* Fix `RTCRtpSender.setStreams` should return a promise
* Fix `RTCPeerConnection.setLocalDescription` parameter is mandatory
* Fix `RTCPeerConnection.setRemoteDescription` parameter is mandatory
* Fix `RTCPeerConnection.addIceCandidate` parameter is mandatory
* Fix `RTCPeerConnection.addTrack` stream parameter is an array of `MediaStream`
* Fix `RTCPeerConnection.addTransceiver` init parameter is type of type `RTCRtpTransceiverInit`

### 1.0.0-beta-001

* First release
