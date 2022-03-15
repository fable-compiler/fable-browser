namespace Browser.Types

open System
open Fable.Core

type [<AllowNullLiteral; Global>] DOMException =
    abstract code: float with get, set
    abstract message: string with get, set
    abstract name: string with get, set
    abstract ABORT_ERR: float with get, set
    abstract DATA_CLONE_ERR: float with get, set
    abstract DOMSTRING_SIZE_ERR: float with get, set
    abstract HIERARCHY_REQUEST_ERR: float with get, set
    abstract INDEX_SIZE_ERR: float with get, set
    abstract INUSE_ATTRIBUTE_ERR: float with get, set
    abstract INVALID_ACCESS_ERR: float with get, set
    abstract INVALID_CHARACTER_ERR: float with get, set
    abstract INVALID_MODIFICATION_ERR: float with get, set
    abstract INVALID_NODE_TYPE_ERR: float with get, set
    abstract INVALID_STATE_ERR: float with get, set
    abstract NAMESPACE_ERR: float with get, set
    abstract NETWORK_ERR: float with get, set
    abstract NOT_FOUND_ERR: float with get, set
    abstract NOT_SUPPORTED_ERR: float with get, set
    abstract NO_DATA_ALLOWED_ERR: float with get, set
    abstract NO_MODIFICATION_ALLOWED_ERR: float with get, set
    abstract PARSE_ERR: float with get, set
    abstract QUOTA_EXCEEDED_ERR: float with get, set
    abstract SECURITY_ERR: float with get, set
    abstract SERIALIZE_ERR: float with get, set
    abstract SYNTAX_ERR: float with get, set
    abstract TIMEOUT_ERR: float with get, set
    abstract TYPE_MISMATCH_ERR: float with get, set
    abstract URL_MISMATCH_ERR: float with get, set
    abstract VALIDATION_ERR: float with get, set
    abstract WRONG_DOCUMENT_ERR: float with get, set
    abstract toString: unit -> string

type [<AllowNullLiteral>] DOMExceptionType =
    abstract ABORT_ERR: float with get, set
    abstract DATA_CLONE_ERR: float with get, set
    abstract DOMSTRING_SIZE_ERR: float with get, set
    abstract HIERARCHY_REQUEST_ERR: float with get, set
    abstract INDEX_SIZE_ERR: float with get, set
    abstract INUSE_ATTRIBUTE_ERR: float with get, set
    abstract INVALID_ACCESS_ERR: float with get, set
    abstract INVALID_CHARACTER_ERR: float with get, set
    abstract INVALID_MODIFICATION_ERR: float with get, set
    abstract INVALID_NODE_TYPE_ERR: float with get, set
    abstract INVALID_STATE_ERR: float with get, set
    abstract NAMESPACE_ERR: float with get, set
    abstract NETWORK_ERR: float with get, set
    abstract NOT_FOUND_ERR: float with get, set
    abstract NOT_SUPPORTED_ERR: float with get, set
    abstract NO_DATA_ALLOWED_ERR: float with get, set
    abstract NO_MODIFICATION_ALLOWED_ERR: float with get, set
    abstract PARSE_ERR: float with get, set
    abstract QUOTA_EXCEEDED_ERR: float with get, set
    abstract SECURITY_ERR: float with get, set
    abstract SERIALIZE_ERR: float with get, set
    abstract SYNTAX_ERR: float with get, set
    abstract TIMEOUT_ERR: float with get, set
    abstract TYPE_MISMATCH_ERR: float with get, set
    abstract URL_MISMATCH_ERR: float with get, set
    abstract VALIDATION_ERR: float with get, set
    abstract WRONG_DOCUMENT_ERR: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> DOMException
