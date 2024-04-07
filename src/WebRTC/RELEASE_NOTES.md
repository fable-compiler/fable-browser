### 1.6.0 

* Align Fable.Core version to 3.2.8 for all of fable-browser packages

### 1.5.0 

* Add `tags` to make binding displayed on Fable.Packages

### 1.4.0

* Add Global attribute to global interfaces @chkn

### 1.3.4

* Downgrade FSharp.Core to 4.7.2

### 1.3.3

* Downgrade FSharp.Core to 4.7.2

### 1.3.2

* Release a new version because one of the dependencies had the licence information missing

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
