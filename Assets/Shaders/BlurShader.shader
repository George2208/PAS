Shader "Custom/BlurShader"{
	Properties
	{
		_MainTex("Basic Texture", 2D) = "white" {}
		_BlurSize("Blur Strength", Range(0, 0.3)) = 0
        [KeywordEnum(Default, More, Enough)] _Examples ("Number of examples", Float) = 0
	}
    Subshader
    {
        Pass
        {
            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile _exDefault, _exMore, _exEnough

            #define EXAMPLES = 10


            #if _exDefault
                #define EXAMPLES 10
            #elif _exMore
                #define EXAMPLES 25
            #else
                #define EXAMPLES 40
            #endif

            sampler2D _MainTex;
            float _BlurSize;

            struct vertexInput
            {
                float4 vertex: POSITION;
                float2 uv: TEXCOORD0;
            };

            struct vertexOutput
            {
                float4 pos : SV_POSITION;
                float2 uv: TEXCOORD0;
            };

            vertexOutput vert(vertexInput v)
            {
                vertexOutput o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag(vertexOutput i) : SV_TARGET
            {
                float4 col = 0;
                for (float j = 0; j < EXAMPLES; j++)  
                {
                    float2 uv = i.uv + float2(0, (j / EXAMPLES) * _BlurSize);
                    col += tex2D(_MainTex, uv);
                }
                return col / EXAMPLES;
            }
            ENDCG
        }
    }
}