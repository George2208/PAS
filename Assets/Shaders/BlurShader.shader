Shader "Custom/BlurShader"{
	Properties
	{
		_MainTex("Basic Texture", 2D) = "white" {}
		_BlurSize("Blur Strength", Range(0, 0.3)) = 0
        _Glow ("Intensity", Range(0, 5)) = 1
        [KeywordEnum(Default, More, Enough)] _Examples ("Number of examples", Float) = 0
	}
    Subshader
    {
        Pass
        {
            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag

            #define EXAMPLES 10

            sampler2D _MainTex;
            float _BlurSize;
            float _Glow;
            float _vigOn;

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
                
                if (_vigOn != 0) 
                {
                    float vigEffect = 1 - length(i.uv * 2 - 1) / 1.4;
                    return (col / EXAMPLES) * _Glow * vigEffect;
                }
                return (col / EXAMPLES) * _Glow;
            }
            ENDCG
        }
    }
}