Shader "TrueGames/BasicDiffuse" {
	Properties{
		_EmissiveColor("Emissive Color", Color) = (1,1,1,1)
		_AmbientColor("Ambient Color", Color) = (1,1,1,1)
		_Slider("Slider", Range(0,10)) = 2.5
	}
		SubShader{
			Tags { "RenderType" = "Opaque" }
			LOD 200

			CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf BasicDiffuse
		#pragma target 3.0


		float4 _EmissiveColor;
		float4 _AmbientColor;
		float _Slider;

		struct Input
		{
			float uf_MainTex;
		};

		inline float4 LightingBasicDiffuse(SurfaceOutput s, fixed3 lightDir, fixed atten) {
			float difLight = dot(s.Normal, lightDir);
			float hLambert = difLight * 0.5 + 0.5;

			float4 col;
			col.rgb = s.Albedo * _LightColor0.rgb * (hLambert * atten * 2);
			col.a = s.Alpha;
			return col;
		}

		void surf(Input IN, inout SurfaceOutput o) {
			float4 c;
			c = pow((_EmissiveColor + _AmbientColor), _Slider);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
		FallBack "Diffuse"
}
