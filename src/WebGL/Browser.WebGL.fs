namespace Browser.Types

open System
open Fable.Core
open Fable.Core.JS

type [<AllowNullLiteral>] WebGLContextAttributes =
    abstract alpha: bool option with get, set
    abstract depth: bool option with get, set
    abstract stencil: bool option with get, set
    abstract antialias: bool option with get, set
    abstract premultipliedAlpha: bool option with get, set
    abstract preserveDrawingBuffer: bool option with get, set

type [<AllowNullLiteral>] WebGLContextEventInit =
    inherit EventInit
    abstract statusMessage: string option with get, set

type [<AllowNullLiteral>] WebGLObject =
    interface end

type [<AllowNullLiteral>] WebGLObjectType =
    abstract prototype: WebGLObject with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLObject

type [<AllowNullLiteral>] WEBGL_compressed_texture_s3tc =
    abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: float with get, set
    abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: float with get, set
    abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: float with get, set
    abstract COMPRESSED_RGB_S3TC_DXT1_EXT: float with get, set

type [<AllowNullLiteral>] WEBGL_compressed_texture_s3tcType =
    abstract prototype: WEBGL_compressed_texture_s3tc with get, set
    abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: float with get, set
    abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: float with get, set
    abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: float with get, set
    abstract COMPRESSED_RGB_S3TC_DXT1_EXT: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WEBGL_compressed_texture_s3tc

type [<AllowNullLiteral>] WEBGL_debug_renderer_info =
    abstract UNMASKED_RENDERER_WEBGL: float with get, set
    abstract UNMASKED_VENDOR_WEBGL: float with get, set

type [<AllowNullLiteral>] WEBGL_debug_renderer_infoType =
    abstract prototype: WEBGL_debug_renderer_info with get, set
    abstract UNMASKED_RENDERER_WEBGL: float with get, set
    abstract UNMASKED_VENDOR_WEBGL: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WEBGL_debug_renderer_info

type [<AllowNullLiteral>] WEBGL_depth_texture =
    abstract UNSIGNED_INT_24_8_WEBGL: float with get, set

type [<AllowNullLiteral>] WEBGL_depth_textureType =
    abstract prototype: WEBGL_depth_texture with get, set
    abstract UNSIGNED_INT_24_8_WEBGL: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WEBGL_depth_texture

type [<AllowNullLiteral>] WebGLActiveInfo =
    abstract name: string with get, set
    abstract size: float with get, set
    abstract ``type``: float with get, set

type [<AllowNullLiteral>] WebGLActiveInfoType =
    abstract prototype: WebGLActiveInfo with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLActiveInfo

type [<AllowNullLiteral>] WebGLBuffer =
    inherit WebGLObject

type [<AllowNullLiteral>] WebGLBufferType =
    abstract prototype: WebGLBuffer with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLBuffer

type [<AllowNullLiteral>] WebGLContextEvent =
    inherit Event
    abstract statusMessage: string with get, set

type [<AllowNullLiteral>] WebGLContextEventType =
    abstract prototype: WebGLContextEvent with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLContextEvent

type [<AllowNullLiteral>] WebGLFramebuffer =
    inherit WebGLObject


type [<AllowNullLiteral>] WebGLFramebufferType =
    abstract prototype: WebGLFramebuffer with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLFramebuffer

type [<AllowNullLiteral>] WebGLProgram =
    inherit WebGLObject

type [<AllowNullLiteral>] WebGLProgramType =
    abstract prototype: WebGLProgram with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLProgram

type [<AllowNullLiteral>] WebGLRenderbuffer =
    inherit WebGLObject

type [<AllowNullLiteral>] WebGLRenderbufferType =
    abstract prototype: WebGLRenderbuffer with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLRenderbuffer

type [<AllowNullLiteral>] WebGLShader =
    inherit WebGLObject

type [<AllowNullLiteral>] WebGLShaderType =
    abstract prototype: WebGLShader with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLShader

type [<AllowNullLiteral>] WebGLShaderPrecisionFormat =
    abstract precision: float with get, set
    abstract rangeMax: float with get, set
    abstract rangeMin: float with get, set

type [<AllowNullLiteral>] WebGLShaderPrecisionFormatType =
    abstract prototype: WebGLShaderPrecisionFormat with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLShaderPrecisionFormat

type [<AllowNullLiteral>] WebGLTexture =
    inherit WebGLObject

type [<AllowNullLiteral>] WebGLTextureType =
    abstract prototype: WebGLTexture with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLTexture

type [<AllowNullLiteral>] WebGLUniformLocation =
    interface end

type [<AllowNullLiteral>] WebGLUniformLocationType =
    abstract prototype: WebGLUniformLocation with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLUniformLocation

type [<AllowNullLiteral>] WebGLRenderingContext =
    abstract canvas: HTMLCanvasElement with get, set
    abstract drawingBufferHeight: float with get, set
    abstract drawingBufferWidth: float with get, set
    abstract ACTIVE_ATTRIBUTES: float with get, set
    abstract ACTIVE_TEXTURE: float with get, set
    abstract ACTIVE_UNIFORMS: float with get, set
    abstract ALIASED_LINE_WIDTH_RANGE: float with get, set
    abstract ALIASED_POINT_SIZE_RANGE: float with get, set
    abstract ALPHA: float with get, set
    abstract ALPHA_BITS: float with get, set
    abstract ALWAYS: float with get, set
    abstract ARRAY_BUFFER: float with get, set
    abstract ARRAY_BUFFER_BINDING: float with get, set
    abstract ATTACHED_SHADERS: float with get, set
    abstract BACK: float with get, set
    abstract BLEND: float with get, set
    abstract BLEND_COLOR: float with get, set
    abstract BLEND_DST_ALPHA: float with get, set
    abstract BLEND_DST_RGB: float with get, set
    abstract BLEND_EQUATION: float with get, set
    abstract BLEND_EQUATION_ALPHA: float with get, set
    abstract BLEND_EQUATION_RGB: float with get, set
    abstract BLEND_SRC_ALPHA: float with get, set
    abstract BLEND_SRC_RGB: float with get, set
    abstract BLUE_BITS: float with get, set
    abstract BOOL: float with get, set
    abstract BOOL_VEC2: float with get, set
    abstract BOOL_VEC3: float with get, set
    abstract BOOL_VEC4: float with get, set
    abstract BROWSER_DEFAULT_WEBGL: float with get, set
    abstract BUFFER_SIZE: float with get, set
    abstract BUFFER_USAGE: float with get, set
    abstract BYTE: float with get, set
    abstract CCW: float with get, set
    abstract CLAMP_TO_EDGE: float with get, set
    abstract COLOR_ATTACHMENT0: float with get, set
    abstract COLOR_BUFFER_BIT: float with get, set
    abstract COLOR_CLEAR_VALUE: float with get, set
    abstract COLOR_WRITEMASK: float with get, set
    abstract COMPILE_STATUS: float with get, set
    abstract COMPRESSED_TEXTURE_FORMATS: float with get, set
    abstract CONSTANT_ALPHA: float with get, set
    abstract CONSTANT_COLOR: float with get, set
    abstract CONTEXT_LOST_WEBGL: float with get, set
    abstract CULL_FACE: float with get, set
    abstract CULL_FACE_MODE: float with get, set
    abstract CURRENT_PROGRAM: float with get, set
    abstract CURRENT_VERTEX_ATTRIB: float with get, set
    abstract CW: float with get, set
    abstract DECR: float with get, set
    abstract DECR_WRAP: float with get, set
    abstract DELETE_STATUS: float with get, set
    abstract DEPTH_ATTACHMENT: float with get, set
    abstract DEPTH_BITS: float with get, set
    abstract DEPTH_BUFFER_BIT: float with get, set
    abstract DEPTH_CLEAR_VALUE: float with get, set
    abstract DEPTH_COMPONENT: float with get, set
    abstract DEPTH_COMPONENT16: float with get, set
    abstract DEPTH_FUNC: float with get, set
    abstract DEPTH_RANGE: float with get, set
    abstract DEPTH_STENCIL: float with get, set
    abstract DEPTH_STENCIL_ATTACHMENT: float with get, set
    abstract DEPTH_TEST: float with get, set
    abstract DEPTH_WRITEMASK: float with get, set
    abstract DITHER: float with get, set
    abstract DONT_CARE: float with get, set
    abstract DST_ALPHA: float with get, set
    abstract DST_COLOR: float with get, set
    abstract DYNAMIC_DRAW: float with get, set
    abstract ELEMENT_ARRAY_BUFFER: float with get, set
    abstract ELEMENT_ARRAY_BUFFER_BINDING: float with get, set
    abstract EQUAL: float with get, set
    abstract FASTEST: float with get, set
    abstract FLOAT: float with get, set
    abstract FLOAT_MAT2: float with get, set
    abstract FLOAT_MAT3: float with get, set
    abstract FLOAT_MAT4: float with get, set
    abstract FLOAT_VEC2: float with get, set
    abstract FLOAT_VEC3: float with get, set
    abstract FLOAT_VEC4: float with get, set
    abstract FRAGMENT_SHADER: float with get, set
    abstract FRAMEBUFFER: float with get, set
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_NAME: float with get, set
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE: float with get, set
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE: float with get, set
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL: float with get, set
    abstract FRAMEBUFFER_BINDING: float with get, set
    abstract FRAMEBUFFER_COMPLETE: float with get, set
    abstract FRAMEBUFFER_INCOMPLETE_ATTACHMENT: float with get, set
    abstract FRAMEBUFFER_INCOMPLETE_DIMENSIONS: float with get, set
    abstract FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT: float with get, set
    abstract FRAMEBUFFER_UNSUPPORTED: float with get, set
    abstract FRONT: float with get, set
    abstract FRONT_AND_BACK: float with get, set
    abstract FRONT_FACE: float with get, set
    abstract FUNC_ADD: float with get, set
    abstract FUNC_REVERSE_SUBTRACT: float with get, set
    abstract FUNC_SUBTRACT: float with get, set
    abstract GENERATE_MIPMAP_HINT: float with get, set
    abstract GEQUAL: float with get, set
    abstract GREATER: float with get, set
    abstract GREEN_BITS: float with get, set
    abstract HIGH_FLOAT: float with get, set
    abstract HIGH_INT: float with get, set
    abstract IMPLEMENTATION_COLOR_READ_FORMAT: float with get, set
    abstract IMPLEMENTATION_COLOR_READ_TYPE: float with get, set
    abstract INCR: float with get, set
    abstract INCR_WRAP: float with get, set
    abstract INT: float with get, set
    abstract INT_VEC2: float with get, set
    abstract INT_VEC3: float with get, set
    abstract INT_VEC4: float with get, set
    abstract INVALID_ENUM: float with get, set
    abstract INVALID_FRAMEBUFFER_OPERATION: float with get, set
    abstract INVALID_OPERATION: float with get, set
    abstract INVALID_VALUE: float with get, set
    abstract INVERT: float with get, set
    abstract KEEP: float with get, set
    abstract LEQUAL: float with get, set
    abstract LESS: float with get, set
    abstract LINEAR: float with get, set
    abstract LINEAR_MIPMAP_LINEAR: float with get, set
    abstract LINEAR_MIPMAP_NEAREST: float with get, set
    abstract LINES: float with get, set
    abstract LINE_LOOP: float with get, set
    abstract LINE_STRIP: float with get, set
    abstract LINE_WIDTH: float with get, set
    abstract LINK_STATUS: float with get, set
    abstract LOW_FLOAT: float with get, set
    abstract LOW_INT: float with get, set
    abstract LUMINANCE: float with get, set
    abstract LUMINANCE_ALPHA: float with get, set
    abstract MAX_COMBINED_TEXTURE_IMAGE_UNITS: float with get, set
    abstract MAX_CUBE_MAP_TEXTURE_SIZE: float with get, set
    abstract MAX_FRAGMENT_UNIFORM_VECTORS: float with get, set
    abstract MAX_RENDERBUFFER_SIZE: float with get, set
    abstract MAX_TEXTURE_IMAGE_UNITS: float with get, set
    abstract MAX_TEXTURE_SIZE: float with get, set
    abstract MAX_VARYING_VECTORS: float with get, set
    abstract MAX_VERTEX_ATTRIBS: float with get, set
    abstract MAX_VERTEX_TEXTURE_IMAGE_UNITS: float with get, set
    abstract MAX_VERTEX_UNIFORM_VECTORS: float with get, set
    abstract MAX_VIEWPORT_DIMS: float with get, set
    abstract MEDIUM_FLOAT: float with get, set
    abstract MEDIUM_INT: float with get, set
    abstract MIRRORED_REPEAT: float with get, set
    abstract NEAREST: float with get, set
    abstract NEAREST_MIPMAP_LINEAR: float with get, set
    abstract NEAREST_MIPMAP_NEAREST: float with get, set
    abstract NEVER: float with get, set
    abstract NICEST: float with get, set
    abstract NONE: float with get, set
    abstract NOTEQUAL: float with get, set
    abstract NO_ERROR: float with get, set
    abstract ONE: float with get, set
    abstract ONE_MINUS_CONSTANT_ALPHA: float with get, set
    abstract ONE_MINUS_CONSTANT_COLOR: float with get, set
    abstract ONE_MINUS_DST_ALPHA: float with get, set
    abstract ONE_MINUS_DST_COLOR: float with get, set
    abstract ONE_MINUS_SRC_ALPHA: float with get, set
    abstract ONE_MINUS_SRC_COLOR: float with get, set
    abstract OUT_OF_MEMORY: float with get, set
    abstract PACK_ALIGNMENT: float with get, set
    abstract POINTS: float with get, set
    abstract POLYGON_OFFSET_FACTOR: float with get, set
    abstract POLYGON_OFFSET_FILL: float with get, set
    abstract POLYGON_OFFSET_UNITS: float with get, set
    abstract RED_BITS: float with get, set
    abstract RENDERBUFFER: float with get, set
    abstract RENDERBUFFER_ALPHA_SIZE: float with get, set
    abstract RENDERBUFFER_BINDING: float with get, set
    abstract RENDERBUFFER_BLUE_SIZE: float with get, set
    abstract RENDERBUFFER_DEPTH_SIZE: float with get, set
    abstract RENDERBUFFER_GREEN_SIZE: float with get, set
    abstract RENDERBUFFER_HEIGHT: float with get, set
    abstract RENDERBUFFER_INTERNAL_FORMAT: float with get, set
    abstract RENDERBUFFER_RED_SIZE: float with get, set
    abstract RENDERBUFFER_STENCIL_SIZE: float with get, set
    abstract RENDERBUFFER_WIDTH: float with get, set
    abstract RENDERER: float with get, set
    abstract REPEAT: float with get, set
    abstract REPLACE: float with get, set
    abstract RGB: float with get, set
    abstract RGB565: float with get, set
    abstract RGB5_A1: float with get, set
    abstract RGBA: float with get, set
    abstract RGBA4: float with get, set
    abstract SAMPLER_2D: float with get, set
    abstract SAMPLER_CUBE: float with get, set
    abstract SAMPLES: float with get, set
    abstract SAMPLE_ALPHA_TO_COVERAGE: float with get, set
    abstract SAMPLE_BUFFERS: float with get, set
    abstract SAMPLE_COVERAGE: float with get, set
    abstract SAMPLE_COVERAGE_INVERT: float with get, set
    abstract SAMPLE_COVERAGE_VALUE: float with get, set
    abstract SCISSOR_BOX: float with get, set
    abstract SCISSOR_TEST: float with get, set
    abstract SHADER_TYPE: float with get, set
    abstract SHADING_LANGUAGE_VERSION: float with get, set
    abstract SHORT: float with get, set
    abstract SRC_ALPHA: float with get, set
    abstract SRC_ALPHA_SATURATE: float with get, set
    abstract SRC_COLOR: float with get, set
    abstract STATIC_DRAW: float with get, set
    abstract STENCIL_ATTACHMENT: float with get, set
    abstract STENCIL_BACK_FAIL: float with get, set
    abstract STENCIL_BACK_FUNC: float with get, set
    abstract STENCIL_BACK_PASS_DEPTH_FAIL: float with get, set
    abstract STENCIL_BACK_PASS_DEPTH_PASS: float with get, set
    abstract STENCIL_BACK_REF: float with get, set
    abstract STENCIL_BACK_VALUE_MASK: float with get, set
    abstract STENCIL_BACK_WRITEMASK: float with get, set
    abstract STENCIL_BITS: float with get, set
    abstract STENCIL_BUFFER_BIT: float with get, set
    abstract STENCIL_CLEAR_VALUE: float with get, set
    abstract STENCIL_FAIL: float with get, set
    abstract STENCIL_FUNC: float with get, set
    abstract STENCIL_INDEX: float with get, set
    abstract STENCIL_INDEX8: float with get, set
    abstract STENCIL_PASS_DEPTH_FAIL: float with get, set
    abstract STENCIL_PASS_DEPTH_PASS: float with get, set
    abstract STENCIL_REF: float with get, set
    abstract STENCIL_TEST: float with get, set
    abstract STENCIL_VALUE_MASK: float with get, set
    abstract STENCIL_WRITEMASK: float with get, set
    abstract STREAM_DRAW: float with get, set
    abstract SUBPIXEL_BITS: float with get, set
    abstract TEXTURE: float with get, set
    abstract TEXTURE0: float with get, set
    abstract TEXTURE1: float with get, set
    abstract TEXTURE10: float with get, set
    abstract TEXTURE11: float with get, set
    abstract TEXTURE12: float with get, set
    abstract TEXTURE13: float with get, set
    abstract TEXTURE14: float with get, set
    abstract TEXTURE15: float with get, set
    abstract TEXTURE16: float with get, set
    abstract TEXTURE17: float with get, set
    abstract TEXTURE18: float with get, set
    abstract TEXTURE19: float with get, set
    abstract TEXTURE2: float with get, set
    abstract TEXTURE20: float with get, set
    abstract TEXTURE21: float with get, set
    abstract TEXTURE22: float with get, set
    abstract TEXTURE23: float with get, set
    abstract TEXTURE24: float with get, set
    abstract TEXTURE25: float with get, set
    abstract TEXTURE26: float with get, set
    abstract TEXTURE27: float with get, set
    abstract TEXTURE28: float with get, set
    abstract TEXTURE29: float with get, set
    abstract TEXTURE3: float with get, set
    abstract TEXTURE30: float with get, set
    abstract TEXTURE31: float with get, set
    abstract TEXTURE4: float with get, set
    abstract TEXTURE5: float with get, set
    abstract TEXTURE6: float with get, set
    abstract TEXTURE7: float with get, set
    abstract TEXTURE8: float with get, set
    abstract TEXTURE9: float with get, set
    abstract TEXTURE_2D: float with get, set
    abstract TEXTURE_BINDING_2D: float with get, set
    abstract TEXTURE_BINDING_CUBE_MAP: float with get, set
    abstract TEXTURE_CUBE_MAP: float with get, set
    abstract TEXTURE_CUBE_MAP_NEGATIVE_X: float with get, set
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Y: float with get, set
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Z: float with get, set
    abstract TEXTURE_CUBE_MAP_POSITIVE_X: float with get, set
    abstract TEXTURE_CUBE_MAP_POSITIVE_Y: float with get, set
    abstract TEXTURE_CUBE_MAP_POSITIVE_Z: float with get, set
    abstract TEXTURE_MAG_FILTER: float with get, set
    abstract TEXTURE_MIN_FILTER: float with get, set
    abstract TEXTURE_WRAP_S: float with get, set
    abstract TEXTURE_WRAP_T: float with get, set
    abstract TRIANGLES: float with get, set
    abstract TRIANGLE_FAN: float with get, set
    abstract TRIANGLE_STRIP: float with get, set
    abstract UNPACK_ALIGNMENT: float with get, set
    abstract UNPACK_COLORSPACE_CONVERSION_WEBGL: float with get, set
    abstract UNPACK_FLIP_Y_WEBGL: float with get, set
    abstract UNPACK_PREMULTIPLY_ALPHA_WEBGL: float with get, set
    abstract UNSIGNED_BYTE: float with get, set
    abstract UNSIGNED_INT: float with get, set
    abstract UNSIGNED_SHORT: float with get, set
    abstract UNSIGNED_SHORT_4_4_4_4: float with get, set
    abstract UNSIGNED_SHORT_5_5_5_1: float with get, set
    abstract UNSIGNED_SHORT_5_6_5: float with get, set
    abstract VALIDATE_STATUS: float with get, set
    abstract VENDOR: float with get, set
    abstract VERSION: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_BUFFER_BINDING: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_ENABLED: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_NORMALIZED: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_POINTER: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_SIZE: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_STRIDE: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_TYPE: float with get, set
    abstract VERTEX_SHADER: float with get, set
    abstract VIEWPORT: float with get, set
    abstract ZERO: float with get, set
    abstract activeTexture: texture: float -> unit
    abstract attachShader: program: WebGLProgram * shader: WebGLShader -> unit
    abstract bindAttribLocation: program: WebGLProgram * index: float * name: string -> unit
    abstract bindBuffer: target: float * buffer: WebGLBuffer -> unit
    abstract bindFramebuffer: target: float * framebuffer: WebGLFramebuffer -> unit
    abstract bindRenderbuffer: target: float * renderbuffer: WebGLRenderbuffer -> unit
    abstract bindTexture: target: float * texture: WebGLTexture -> unit
    abstract blendColor: red: float * green: float * blue: float * alpha: float -> unit
    abstract blendEquation: mode: float -> unit
    abstract blendEquationSeparate: modeRGB: float * modeAlpha: float -> unit
    abstract blendFunc: sfactor: float * dfactor: float -> unit
    abstract blendFuncSeparate: srcRGB: float * dstRGB: float * srcAlpha: float * dstAlpha: float -> unit
    abstract bufferData: target: float * size: U3<float, ArrayBufferView, ArrayBuffer> * usage: float -> unit
    abstract bufferSubData: target: float * offset: float * data: U2<ArrayBufferView, ArrayBuffer> -> unit
    abstract checkFramebufferStatus: target: float -> float
    abstract clear: mask: float -> unit
    abstract clearColor: red: float * green: float * blue: float * alpha: float -> unit
    abstract clearDepth: depth: float -> unit
    abstract clearStencil: s: float -> unit
    abstract colorMask: red: bool * green: bool * blue: bool * alpha: bool -> unit
    abstract compileShader: shader: WebGLShader -> unit
    abstract compressedTexImage2D: target: float * level: float * internalformat: float * width: float * height: float * border: float * data: ArrayBufferView -> unit
    abstract compressedTexSubImage2D: target: float * level: float * xoffset: float * yoffset: float * width: float * height: float * format: float * data: ArrayBufferView -> unit
    abstract copyTexImage2D: target: float * level: float * internalformat: float * x: float * y: float * width: float * height: float * border: float -> unit
    abstract copyTexSubImage2D: target: float * level: float * xoffset: float * yoffset: float * x: float * y: float * width: float * height: float -> unit
    abstract createBuffer: unit -> WebGLBuffer
    abstract createFramebuffer: unit -> WebGLFramebuffer
    abstract createProgram: unit -> WebGLProgram
    abstract createRenderbuffer: unit -> WebGLRenderbuffer
    abstract createShader: ``type``: float -> WebGLShader
    abstract createTexture: unit -> WebGLTexture
    abstract cullFace: mode: float -> unit
    abstract deleteBuffer: buffer: WebGLBuffer -> unit
    abstract deleteFramebuffer: framebuffer: WebGLFramebuffer -> unit
    abstract deleteProgram: program: WebGLProgram -> unit
    abstract deleteRenderbuffer: renderbuffer: WebGLRenderbuffer -> unit
    abstract deleteShader: shader: WebGLShader -> unit
    abstract deleteTexture: texture: WebGLTexture -> unit
    abstract depthFunc: func: float -> unit
    abstract depthMask: flag: bool -> unit
    abstract depthRange: zNear: float * zFar: float -> unit
    abstract detachShader: program: WebGLProgram * shader: WebGLShader -> unit
    abstract disable: cap: float -> unit
    abstract disableVertexAttribArray: index: float -> unit
    abstract drawArrays: mode: float * first: float * count: float -> unit
    abstract drawElements: mode: float * count: float * ``type``: float * offset: float -> unit
    abstract enable: cap: float -> unit
    abstract enableVertexAttribArray: index: float -> unit
    abstract finish: unit -> unit
    abstract flush: unit -> unit
    abstract framebufferRenderbuffer: target: float * attachment: float * renderbuffertarget: float * renderbuffer: WebGLRenderbuffer -> unit
    abstract framebufferTexture2D: target: float * attachment: float * textarget: float * texture: WebGLTexture * level: float -> unit
    abstract frontFace: mode: float -> unit
    abstract generateMipmap: target: float -> unit
    abstract getActiveAttrib: program: WebGLProgram * index: float -> WebGLActiveInfo
    abstract getActiveUniform: program: WebGLProgram * index: float -> WebGLActiveInfo
    abstract getAttachedShaders: program: WebGLProgram -> ResizeArray<WebGLShader>
    abstract getAttribLocation: program: WebGLProgram * name: string -> float
    abstract getBufferParameter: target: float * pname: float -> obj
    abstract getContextAttributes: unit -> WebGLContextAttributes
    abstract getError: unit -> float
    abstract getExtension: name: string -> obj
    abstract getFramebufferAttachmentParameter: target: float * attachment: float * pname: float -> obj
    abstract getParameter: pname: float -> obj
    abstract getProgramInfoLog: program: WebGLProgram -> string
    abstract getProgramParameter: program: WebGLProgram * pname: float -> obj
    abstract getRenderbufferParameter: target: float * pname: float -> obj
    abstract getShaderInfoLog: shader: WebGLShader -> string
    abstract getShaderParameter: shader: WebGLShader * pname: float -> obj
    abstract getShaderPrecisionFormat: shadertype: float * precisiontype: float -> WebGLShaderPrecisionFormat
    abstract getShaderSource: shader: WebGLShader -> string
    abstract getSupportedExtensions: unit -> ResizeArray<string>
    abstract getTexParameter: target: float * pname: float -> obj
    abstract getUniform: program: WebGLProgram * location: WebGLUniformLocation -> obj
    abstract getUniformLocation: program: WebGLProgram * name: string -> WebGLUniformLocation
    abstract getVertexAttrib: index: float * pname: float -> obj
    abstract getVertexAttribOffset: index: float * pname: float -> float
    abstract hint: target: float * mode: float -> unit
    abstract isBuffer: buffer: WebGLBuffer -> bool
    abstract isContextLost: unit -> bool
    abstract isEnabled: cap: float -> bool
    abstract isFramebuffer: framebuffer: WebGLFramebuffer -> bool
    abstract isProgram: program: WebGLProgram -> bool
    abstract isRenderbuffer: renderbuffer: WebGLRenderbuffer -> bool
    abstract isShader: shader: WebGLShader -> bool
    abstract isTexture: texture: WebGLTexture -> bool
    abstract lineWidth: width: float -> unit
    abstract linkProgram: program: WebGLProgram -> unit
    abstract pixelStorei: pname: float * param: float -> unit
    abstract polygonOffset: factor: float * units: float -> unit
    abstract readPixels: x: float * y: float * width: float * height: float * format: float * ``type``: float * pixels: ArrayBufferView -> unit
    abstract renderbufferStorage: target: float * internalformat: float * width: float * height: float -> unit
    abstract sampleCoverage: value: float * invert: bool -> unit
    abstract scissor: x: float * y: float * width: float * height: float -> unit
    abstract shaderSource: shader: WebGLShader * source: string -> unit
    abstract stencilFunc: func: float * ref: float * mask: float -> unit
    abstract stencilFuncSeparate: face: float * func: float * ref: float * mask: float -> unit
    abstract stencilMask: mask: float -> unit
    abstract stencilMaskSeparate: face: float * mask: float -> unit
    abstract stencilOp: fail: float * zfail: float * zpass: float -> unit
    abstract stencilOpSeparate: face: float * fail: float * zfail: float * zpass: float -> unit
    abstract texImage2D: target: float * level: float * internalformat: float * width: float * height: float * border: float * format: float * ``type``: float * pixels: ArrayBufferView -> unit
    abstract texImage2D: target: float * level: float * internalformat: float * format: float * ``type``: float * image: HTMLImageElement -> unit
    abstract texImage2D: target: float * level: float * internalformat: float * format: float * ``type``: float * canvas: HTMLCanvasElement -> unit
    abstract texImage2D: target: float * level: float * internalformat: float * format: float * ``type``: float * video: HTMLVideoElement -> unit
    abstract texImage2D: target: float * level: float * internalformat: float * format: float * ``type``: float * pixels: ImageData -> unit
    abstract texParameterf: target: float * pname: float * param: float -> unit
    abstract texParameteri: target: float * pname: float * param: float -> unit
    abstract texSubImage2D: target: float * level: float * xoffset: float * yoffset: float * width: float * height: float * format: float * ``type``: float * pixels: ArrayBufferView -> unit
    abstract texSubImage2D: target: float * level: float * xoffset: float * yoffset: float * format: float * ``type``: float * image: HTMLImageElement -> unit
    abstract texSubImage2D: target: float * level: float * xoffset: float * yoffset: float * format: float * ``type``: float * canvas: HTMLCanvasElement -> unit
    abstract texSubImage2D: target: float * level: float * xoffset: float * yoffset: float * format: float * ``type``: float * video: HTMLVideoElement -> unit
    abstract texSubImage2D: target: float * level: float * xoffset: float * yoffset: float * format: float * ``type``: float * pixels: ImageData -> unit
    abstract uniform1f: location: WebGLUniformLocation * x: float -> unit
    abstract uniform1fv: location: WebGLUniformLocation * v: Float32Array -> unit
    abstract uniform1i: location: WebGLUniformLocation * x: float -> unit
    abstract uniform1iv: location: WebGLUniformLocation * v: Int32Array -> unit
    abstract uniform2f: location: WebGLUniformLocation * x: float * y: float -> unit
    abstract uniform2fv: location: WebGLUniformLocation * v: Float32Array -> unit
    abstract uniform2i: location: WebGLUniformLocation * x: float * y: float -> unit
    abstract uniform2iv: location: WebGLUniformLocation * v: Int32Array -> unit
    abstract uniform3f: location: WebGLUniformLocation * x: float * y: float * z: float -> unit
    abstract uniform3fv: location: WebGLUniformLocation * v: Float32Array -> unit
    abstract uniform3i: location: WebGLUniformLocation * x: float * y: float * z: float -> unit
    abstract uniform3iv: location: WebGLUniformLocation * v: Int32Array -> unit
    abstract uniform4f: location: WebGLUniformLocation * x: float * y: float * z: float * w: float -> unit
    abstract uniform4fv: location: WebGLUniformLocation * v: Float32Array -> unit
    abstract uniform4i: location: WebGLUniformLocation * x: float * y: float * z: float * w: float -> unit
    abstract uniform4iv: location: WebGLUniformLocation * v: Int32Array -> unit
    abstract uniformMatrix2fv: location: WebGLUniformLocation * transpose: bool * value: Float32Array -> unit
    abstract uniformMatrix3fv: location: WebGLUniformLocation * transpose: bool * value: Float32Array -> unit
    abstract uniformMatrix4fv: location: WebGLUniformLocation * transpose: bool * value: Float32Array -> unit
    abstract useProgram: program: WebGLProgram -> unit
    abstract validateProgram: program: WebGLProgram -> unit
    abstract vertexAttrib1f: indx: float * x: float -> unit
    abstract vertexAttrib1fv: indx: float * values: Float32Array -> unit
    abstract vertexAttrib2f: indx: float * x: float * y: float -> unit
    abstract vertexAttrib2fv: indx: float * values: Float32Array -> unit
    abstract vertexAttrib3f: indx: float * x: float * y: float * z: float -> unit
    abstract vertexAttrib3fv: indx: float * values: Float32Array -> unit
    abstract vertexAttrib4f: indx: float * x: float * y: float * z: float * w: float -> unit
    abstract vertexAttrib4fv: indx: float * values: Float32Array -> unit
    abstract vertexAttribPointer: indx: float * size: float * ``type``: float * normalized: bool * stride: float * offset: float -> unit
    abstract viewport: x: float * y: float * width: float * height: float -> unit

type [<AllowNullLiteral>] WebGLRenderingContextType =
    abstract prototype: WebGLRenderingContext with get, set
    abstract ACTIVE_ATTRIBUTES: float with get, set
    abstract ACTIVE_TEXTURE: float with get, set
    abstract ACTIVE_UNIFORMS: float with get, set
    abstract ALIASED_LINE_WIDTH_RANGE: float with get, set
    abstract ALIASED_POINT_SIZE_RANGE: float with get, set
    abstract ALPHA: float with get, set
    abstract ALPHA_BITS: float with get, set
    abstract ALWAYS: float with get, set
    abstract ARRAY_BUFFER: float with get, set
    abstract ARRAY_BUFFER_BINDING: float with get, set
    abstract ATTACHED_SHADERS: float with get, set
    abstract BACK: float with get, set
    abstract BLEND: float with get, set
    abstract BLEND_COLOR: float with get, set
    abstract BLEND_DST_ALPHA: float with get, set
    abstract BLEND_DST_RGB: float with get, set
    abstract BLEND_EQUATION: float with get, set
    abstract BLEND_EQUATION_ALPHA: float with get, set
    abstract BLEND_EQUATION_RGB: float with get, set
    abstract BLEND_SRC_ALPHA: float with get, set
    abstract BLEND_SRC_RGB: float with get, set
    abstract BLUE_BITS: float with get, set
    abstract BOOL: float with get, set
    abstract BOOL_VEC2: float with get, set
    abstract BOOL_VEC3: float with get, set
    abstract BOOL_VEC4: float with get, set
    abstract BROWSER_DEFAULT_WEBGL: float with get, set
    abstract BUFFER_SIZE: float with get, set
    abstract BUFFER_USAGE: float with get, set
    abstract BYTE: float with get, set
    abstract CCW: float with get, set
    abstract CLAMP_TO_EDGE: float with get, set
    abstract COLOR_ATTACHMENT0: float with get, set
    abstract COLOR_BUFFER_BIT: float with get, set
    abstract COLOR_CLEAR_VALUE: float with get, set
    abstract COLOR_WRITEMASK: float with get, set
    abstract COMPILE_STATUS: float with get, set
    abstract COMPRESSED_TEXTURE_FORMATS: float with get, set
    abstract CONSTANT_ALPHA: float with get, set
    abstract CONSTANT_COLOR: float with get, set
    abstract CONTEXT_LOST_WEBGL: float with get, set
    abstract CULL_FACE: float with get, set
    abstract CULL_FACE_MODE: float with get, set
    abstract CURRENT_PROGRAM: float with get, set
    abstract CURRENT_VERTEX_ATTRIB: float with get, set
    abstract CW: float with get, set
    abstract DECR: float with get, set
    abstract DECR_WRAP: float with get, set
    abstract DELETE_STATUS: float with get, set
    abstract DEPTH_ATTACHMENT: float with get, set
    abstract DEPTH_BITS: float with get, set
    abstract DEPTH_BUFFER_BIT: float with get, set
    abstract DEPTH_CLEAR_VALUE: float with get, set
    abstract DEPTH_COMPONENT: float with get, set
    abstract DEPTH_COMPONENT16: float with get, set
    abstract DEPTH_FUNC: float with get, set
    abstract DEPTH_RANGE: float with get, set
    abstract DEPTH_STENCIL: float with get, set
    abstract DEPTH_STENCIL_ATTACHMENT: float with get, set
    abstract DEPTH_TEST: float with get, set
    abstract DEPTH_WRITEMASK: float with get, set
    abstract DITHER: float with get, set
    abstract DONT_CARE: float with get, set
    abstract DST_ALPHA: float with get, set
    abstract DST_COLOR: float with get, set
    abstract DYNAMIC_DRAW: float with get, set
    abstract ELEMENT_ARRAY_BUFFER: float with get, set
    abstract ELEMENT_ARRAY_BUFFER_BINDING: float with get, set
    abstract EQUAL: float with get, set
    abstract FASTEST: float with get, set
    abstract FLOAT: float with get, set
    abstract FLOAT_MAT2: float with get, set
    abstract FLOAT_MAT3: float with get, set
    abstract FLOAT_MAT4: float with get, set
    abstract FLOAT_VEC2: float with get, set
    abstract FLOAT_VEC3: float with get, set
    abstract FLOAT_VEC4: float with get, set
    abstract FRAGMENT_SHADER: float with get, set
    abstract FRAMEBUFFER: float with get, set
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_NAME: float with get, set
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE: float with get, set
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE: float with get, set
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL: float with get, set
    abstract FRAMEBUFFER_BINDING: float with get, set
    abstract FRAMEBUFFER_COMPLETE: float with get, set
    abstract FRAMEBUFFER_INCOMPLETE_ATTACHMENT: float with get, set
    abstract FRAMEBUFFER_INCOMPLETE_DIMENSIONS: float with get, set
    abstract FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT: float with get, set
    abstract FRAMEBUFFER_UNSUPPORTED: float with get, set
    abstract FRONT: float with get, set
    abstract FRONT_AND_BACK: float with get, set
    abstract FRONT_FACE: float with get, set
    abstract FUNC_ADD: float with get, set
    abstract FUNC_REVERSE_SUBTRACT: float with get, set
    abstract FUNC_SUBTRACT: float with get, set
    abstract GENERATE_MIPMAP_HINT: float with get, set
    abstract GEQUAL: float with get, set
    abstract GREATER: float with get, set
    abstract GREEN_BITS: float with get, set
    abstract HIGH_FLOAT: float with get, set
    abstract HIGH_INT: float with get, set
    abstract IMPLEMENTATION_COLOR_READ_FORMAT: float with get, set
    abstract IMPLEMENTATION_COLOR_READ_TYPE: float with get, set
    abstract INCR: float with get, set
    abstract INCR_WRAP: float with get, set
    abstract INT: float with get, set
    abstract INT_VEC2: float with get, set
    abstract INT_VEC3: float with get, set
    abstract INT_VEC4: float with get, set
    abstract INVALID_ENUM: float with get, set
    abstract INVALID_FRAMEBUFFER_OPERATION: float with get, set
    abstract INVALID_OPERATION: float with get, set
    abstract INVALID_VALUE: float with get, set
    abstract INVERT: float with get, set
    abstract KEEP: float with get, set
    abstract LEQUAL: float with get, set
    abstract LESS: float with get, set
    abstract LINEAR: float with get, set
    abstract LINEAR_MIPMAP_LINEAR: float with get, set
    abstract LINEAR_MIPMAP_NEAREST: float with get, set
    abstract LINES: float with get, set
    abstract LINE_LOOP: float with get, set
    abstract LINE_STRIP: float with get, set
    abstract LINE_WIDTH: float with get, set
    abstract LINK_STATUS: float with get, set
    abstract LOW_FLOAT: float with get, set
    abstract LOW_INT: float with get, set
    abstract LUMINANCE: float with get, set
    abstract LUMINANCE_ALPHA: float with get, set
    abstract MAX_COMBINED_TEXTURE_IMAGE_UNITS: float with get, set
    abstract MAX_CUBE_MAP_TEXTURE_SIZE: float with get, set
    abstract MAX_FRAGMENT_UNIFORM_VECTORS: float with get, set
    abstract MAX_RENDERBUFFER_SIZE: float with get, set
    abstract MAX_TEXTURE_IMAGE_UNITS: float with get, set
    abstract MAX_TEXTURE_SIZE: float with get, set
    abstract MAX_VARYING_VECTORS: float with get, set
    abstract MAX_VERTEX_ATTRIBS: float with get, set
    abstract MAX_VERTEX_TEXTURE_IMAGE_UNITS: float with get, set
    abstract MAX_VERTEX_UNIFORM_VECTORS: float with get, set
    abstract MAX_VIEWPORT_DIMS: float with get, set
    abstract MEDIUM_FLOAT: float with get, set
    abstract MEDIUM_INT: float with get, set
    abstract MIRRORED_REPEAT: float with get, set
    abstract NEAREST: float with get, set
    abstract NEAREST_MIPMAP_LINEAR: float with get, set
    abstract NEAREST_MIPMAP_NEAREST: float with get, set
    abstract NEVER: float with get, set
    abstract NICEST: float with get, set
    abstract NONE: float with get, set
    abstract NOTEQUAL: float with get, set
    abstract NO_ERROR: float with get, set
    abstract ONE: float with get, set
    abstract ONE_MINUS_CONSTANT_ALPHA: float with get, set
    abstract ONE_MINUS_CONSTANT_COLOR: float with get, set
    abstract ONE_MINUS_DST_ALPHA: float with get, set
    abstract ONE_MINUS_DST_COLOR: float with get, set
    abstract ONE_MINUS_SRC_ALPHA: float with get, set
    abstract ONE_MINUS_SRC_COLOR: float with get, set
    abstract OUT_OF_MEMORY: float with get, set
    abstract PACK_ALIGNMENT: float with get, set
    abstract POINTS: float with get, set
    abstract POLYGON_OFFSET_FACTOR: float with get, set
    abstract POLYGON_OFFSET_FILL: float with get, set
    abstract POLYGON_OFFSET_UNITS: float with get, set
    abstract RED_BITS: float with get, set
    abstract RENDERBUFFER: float with get, set
    abstract RENDERBUFFER_ALPHA_SIZE: float with get, set
    abstract RENDERBUFFER_BINDING: float with get, set
    abstract RENDERBUFFER_BLUE_SIZE: float with get, set
    abstract RENDERBUFFER_DEPTH_SIZE: float with get, set
    abstract RENDERBUFFER_GREEN_SIZE: float with get, set
    abstract RENDERBUFFER_HEIGHT: float with get, set
    abstract RENDERBUFFER_INTERNAL_FORMAT: float with get, set
    abstract RENDERBUFFER_RED_SIZE: float with get, set
    abstract RENDERBUFFER_STENCIL_SIZE: float with get, set
    abstract RENDERBUFFER_WIDTH: float with get, set
    abstract RENDERER: float with get, set
    abstract REPEAT: float with get, set
    abstract REPLACE: float with get, set
    abstract RGB: float with get, set
    abstract RGB565: float with get, set
    abstract RGB5_A1: float with get, set
    abstract RGBA: float with get, set
    abstract RGBA4: float with get, set
    abstract SAMPLER_2D: float with get, set
    abstract SAMPLER_CUBE: float with get, set
    abstract SAMPLES: float with get, set
    abstract SAMPLE_ALPHA_TO_COVERAGE: float with get, set
    abstract SAMPLE_BUFFERS: float with get, set
    abstract SAMPLE_COVERAGE: float with get, set
    abstract SAMPLE_COVERAGE_INVERT: float with get, set
    abstract SAMPLE_COVERAGE_VALUE: float with get, set
    abstract SCISSOR_BOX: float with get, set
    abstract SCISSOR_TEST: float with get, set
    abstract SHADER_TYPE: float with get, set
    abstract SHADING_LANGUAGE_VERSION: float with get, set
    abstract SHORT: float with get, set
    abstract SRC_ALPHA: float with get, set
    abstract SRC_ALPHA_SATURATE: float with get, set
    abstract SRC_COLOR: float with get, set
    abstract STATIC_DRAW: float with get, set
    abstract STENCIL_ATTACHMENT: float with get, set
    abstract STENCIL_BACK_FAIL: float with get, set
    abstract STENCIL_BACK_FUNC: float with get, set
    abstract STENCIL_BACK_PASS_DEPTH_FAIL: float with get, set
    abstract STENCIL_BACK_PASS_DEPTH_PASS: float with get, set
    abstract STENCIL_BACK_REF: float with get, set
    abstract STENCIL_BACK_VALUE_MASK: float with get, set
    abstract STENCIL_BACK_WRITEMASK: float with get, set
    abstract STENCIL_BITS: float with get, set
    abstract STENCIL_BUFFER_BIT: float with get, set
    abstract STENCIL_CLEAR_VALUE: float with get, set
    abstract STENCIL_FAIL: float with get, set
    abstract STENCIL_FUNC: float with get, set
    abstract STENCIL_INDEX: float with get, set
    abstract STENCIL_INDEX8: float with get, set
    abstract STENCIL_PASS_DEPTH_FAIL: float with get, set
    abstract STENCIL_PASS_DEPTH_PASS: float with get, set
    abstract STENCIL_REF: float with get, set
    abstract STENCIL_TEST: float with get, set
    abstract STENCIL_VALUE_MASK: float with get, set
    abstract STENCIL_WRITEMASK: float with get, set
    abstract STREAM_DRAW: float with get, set
    abstract SUBPIXEL_BITS: float with get, set
    abstract TEXTURE: float with get, set
    abstract TEXTURE0: float with get, set
    abstract TEXTURE1: float with get, set
    abstract TEXTURE10: float with get, set
    abstract TEXTURE11: float with get, set
    abstract TEXTURE12: float with get, set
    abstract TEXTURE13: float with get, set
    abstract TEXTURE14: float with get, set
    abstract TEXTURE15: float with get, set
    abstract TEXTURE16: float with get, set
    abstract TEXTURE17: float with get, set
    abstract TEXTURE18: float with get, set
    abstract TEXTURE19: float with get, set
    abstract TEXTURE2: float with get, set
    abstract TEXTURE20: float with get, set
    abstract TEXTURE21: float with get, set
    abstract TEXTURE22: float with get, set
    abstract TEXTURE23: float with get, set
    abstract TEXTURE24: float with get, set
    abstract TEXTURE25: float with get, set
    abstract TEXTURE26: float with get, set
    abstract TEXTURE27: float with get, set
    abstract TEXTURE28: float with get, set
    abstract TEXTURE29: float with get, set
    abstract TEXTURE3: float with get, set
    abstract TEXTURE30: float with get, set
    abstract TEXTURE31: float with get, set
    abstract TEXTURE4: float with get, set
    abstract TEXTURE5: float with get, set
    abstract TEXTURE6: float with get, set
    abstract TEXTURE7: float with get, set
    abstract TEXTURE8: float with get, set
    abstract TEXTURE9: float with get, set
    abstract TEXTURE_2D: float with get, set
    abstract TEXTURE_BINDING_2D: float with get, set
    abstract TEXTURE_BINDING_CUBE_MAP: float with get, set
    abstract TEXTURE_CUBE_MAP: float with get, set
    abstract TEXTURE_CUBE_MAP_NEGATIVE_X: float with get, set
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Y: float with get, set
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Z: float with get, set
    abstract TEXTURE_CUBE_MAP_POSITIVE_X: float with get, set
    abstract TEXTURE_CUBE_MAP_POSITIVE_Y: float with get, set
    abstract TEXTURE_CUBE_MAP_POSITIVE_Z: float with get, set
    abstract TEXTURE_MAG_FILTER: float with get, set
    abstract TEXTURE_MIN_FILTER: float with get, set
    abstract TEXTURE_WRAP_S: float with get, set
    abstract TEXTURE_WRAP_T: float with get, set
    abstract TRIANGLES: float with get, set
    abstract TRIANGLE_FAN: float with get, set
    abstract TRIANGLE_STRIP: float with get, set
    abstract UNPACK_ALIGNMENT: float with get, set
    abstract UNPACK_COLORSPACE_CONVERSION_WEBGL: float with get, set
    abstract UNPACK_FLIP_Y_WEBGL: float with get, set
    abstract UNPACK_PREMULTIPLY_ALPHA_WEBGL: float with get, set
    abstract UNSIGNED_BYTE: float with get, set
    abstract UNSIGNED_INT: float with get, set
    abstract UNSIGNED_SHORT: float with get, set
    abstract UNSIGNED_SHORT_4_4_4_4: float with get, set
    abstract UNSIGNED_SHORT_5_5_5_1: float with get, set
    abstract UNSIGNED_SHORT_5_6_5: float with get, set
    abstract VALIDATE_STATUS: float with get, set
    abstract VENDOR: float with get, set
    abstract VERSION: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_BUFFER_BINDING: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_ENABLED: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_NORMALIZED: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_POINTER: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_SIZE: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_STRIDE: float with get, set
    abstract VERTEX_ATTRIB_ARRAY_TYPE: float with get, set
    abstract VERTEX_SHADER: float with get, set
    abstract VIEWPORT: float with get, set
    abstract ZERO: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLRenderingContext

namespace Browser

open Browser.Types
open Fable.Core

module WebGL =

    type HTMLCanvasElement with
        [<Emit("$0.getContext('experimental-webgl')")>]
        member __.``getContext_experimental-webgl``: unit -> WebGLRenderingContext = failwith ""

    type DocumentEvent with
        member __.createEvent_WebGLContextEvent: unit -> WebGLContextEvent = failwith ""

    let [<Global>] WEBGL_compressed_texture_s3tc: WEBGL_compressed_texture_s3tcType = jsNative
    let [<Global>] WEBGL_debug_renderer_info: WEBGL_debug_renderer_infoType = jsNative
    let [<Global>] WEBGL_depth_texture: WEBGL_depth_textureType = jsNative
    let [<Global>] WebGLActiveInfo: WebGLActiveInfoType = jsNative
    let [<Global>] WebGLBuffer: WebGLBufferType = jsNative
    let [<Global>] WebGLContextEvent: WebGLContextEventType = jsNative
    let [<Global>] WebGLFramebuffer: WebGLFramebufferType = jsNative
    let [<Global>] WebGLObject: WebGLObjectType = jsNative
    let [<Global>] WebGLProgram: WebGLProgramType = jsNative
    let [<Global>] WebGLRenderbuffer: WebGLRenderbufferType = jsNative
    let [<Global>] WebGLRenderingContext: WebGLRenderingContextType = jsNative
    let [<Global>] WebGLShader: WebGLShaderType = jsNative
    let [<Global>] WebGLShaderPrecisionFormat: WebGLShaderPrecisionFormatType = jsNative
    let [<Global>] WebGLTexture: WebGLTextureType = jsNative
    let [<Global>] WebGLUniformLocation: WebGLUniformLocationType = jsNative
