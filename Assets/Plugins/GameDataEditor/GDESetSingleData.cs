// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// GameDataEditor.GDESetSingleData
using System.Collections.Generic;
using GameDataEditor;
using UnityEngine;

namespace GameDataEditor
{
	public class GDESetSingleData : IGDEData
	{
		private static string bool_fieldKey = "bool_field";

		private bool _bool_field;

		private static string int_fieldKey = "int_field";

		private int _int_field;

		private static string float_fieldKey = "float_field";

		private float _float_field;

		private static string string_fieldKey = "string_field";

		private string _string_field;

		private static string vector2_fieldKey = "vector2_field";

		private Vector2 _vector2_field;

		private static string vector3_fieldKey = "vector3_field";

		private Vector3 _vector3_field;

		private static string vector4_fieldKey = "vector4_field";

		private Vector4 _vector4_field;

		private static string color_fieldKey = "color_field";

		private Color _color_field;

		private static string custom_fieldKey = "custom_field";

		private GDESetCustomData _custom_field;

		public bool bool_field
		{
			get
			{
				return _bool_field;
			}
			set
			{
				if (_bool_field != value)
				{
					_bool_field = value;
					GDEDataManager.SetBool(_key + "_" + bool_fieldKey, _bool_field);
				}
			}
		}

		public int int_field
		{
			get
			{
				return _int_field;
			}
			set
			{
				if (_int_field != value)
				{
					_int_field = value;
					GDEDataManager.SetInt(_key + "_" + int_fieldKey, _int_field);
				}
			}
		}

		public float float_field
		{
			get
			{
				return _float_field;
			}
			set
			{
				if (_float_field != value)
				{
					_float_field = value;
					GDEDataManager.SetFloat(_key + "_" + float_fieldKey, _float_field);
				}
			}
		}

		public string string_field
		{
			get
			{
				return _string_field;
			}
			set
			{
				if (_string_field != value)
				{
					_string_field = value;
					GDEDataManager.SetString(_key + "_" + string_fieldKey, _string_field);
				}
			}
		}

		public Vector2 vector2_field
		{
			get
			{
				return _vector2_field;
			}
			set
			{
				if (_vector2_field != value)
				{
					_vector2_field = value;
					GDEDataManager.SetVector2(_key + "_" + vector2_fieldKey, _vector2_field);
				}
			}
		}

		public Vector3 vector3_field
		{
			get
			{
				return _vector3_field;
			}
			set
			{
				if (_vector3_field != value)
				{
					_vector3_field = value;
					GDEDataManager.SetVector3(_key + "_" + vector3_fieldKey, _vector3_field);
				}
			}
		}

		public Vector4 vector4_field
		{
			get
			{
				return _vector4_field;
			}
			set
			{
				if (_vector4_field != value)
				{
					_vector4_field = value;
					GDEDataManager.SetVector4(_key + "_" + vector4_fieldKey, _vector4_field);
				}
			}
		}

		public Color color_field
		{
			get
			{
				return _color_field;
			}
			set
			{
				if (_color_field != value)
				{
					_color_field = value;
					GDEDataManager.SetColor(_key + "_" + color_fieldKey, _color_field);
				}
			}
		}

		public GDESetCustomData custom_field
		{
			get
			{
				return _custom_field;
			}
			set
			{
				if (_custom_field != value)
				{
					_custom_field = value;
					GDEDataManager.SetCustom(_key + "_" + custom_fieldKey, _custom_field);
				}
			}
		}

		public GDESetSingleData()
		{
			_key = string.Empty;
		}

		public GDESetSingleData(string key)
		{
			_key = key;
		}

		public override void LoadFromDict(string dataKey, Dictionary<string, object> dict)
		{
			_key = dataKey;
			if (dict == null)
			{
				LoadFromSavedData(dataKey);
				return;
			}
			dict.TryGetBool(bool_fieldKey, out _bool_field);
			dict.TryGetInt(int_fieldKey, out _int_field);
			dict.TryGetFloat(float_fieldKey, out _float_field);
			dict.TryGetString(string_fieldKey, out _string_field);
			dict.TryGetVector2(vector2_fieldKey, out _vector2_field);
			dict.TryGetVector3(vector3_fieldKey, out _vector3_field);
			dict.TryGetVector4(vector4_fieldKey, out _vector4_field);
			dict.TryGetColor(color_fieldKey, out _color_field);
			dict.TryGetString(custom_fieldKey, out var value);
			GDEDataManager.DataDictionary.TryGetCustom<string, object, GDESetCustomData>(value, out _custom_field);
			LoadFromSavedData(dataKey);
		}

		public override void LoadFromSavedData(string dataKey)
		{
			_key = dataKey;
			_bool_field = GDEDataManager.GetBool(_key + "_" + bool_fieldKey, _bool_field);
			_int_field = GDEDataManager.GetInt(_key + "_" + int_fieldKey, _int_field);
			_float_field = GDEDataManager.GetFloat(_key + "_" + float_fieldKey, _float_field);
			_string_field = GDEDataManager.GetString(_key + "_" + string_fieldKey, _string_field);
			_vector2_field = GDEDataManager.GetVector2(_key + "_" + vector2_fieldKey, _vector2_field);
			_vector3_field = GDEDataManager.GetVector3(_key + "_" + vector3_fieldKey, _vector3_field);
			_vector4_field = GDEDataManager.GetVector4(_key + "_" + vector4_fieldKey, _vector4_field);
			_color_field = GDEDataManager.GetColor(_key + "_" + color_fieldKey, _color_field);
			_custom_field = GDEDataManager.GetCustom(_key + "_" + custom_fieldKey, _custom_field);
		}

		public void Reset_bool_field()
		{
			GDEDataManager.ResetToDefault(_key, bool_fieldKey);
			GDEDataManager.Get(_key, out var data);
			data.TryGetBool(bool_fieldKey, out _bool_field);
		}

		public void Reset_int_field()
		{
			GDEDataManager.ResetToDefault(_key, int_fieldKey);
			GDEDataManager.Get(_key, out var data);
			data.TryGetInt(int_fieldKey, out _int_field);
		}

		public void Reset_float_field()
		{
			GDEDataManager.ResetToDefault(_key, float_fieldKey);
			GDEDataManager.Get(_key, out var data);
			data.TryGetFloat(float_fieldKey, out _float_field);
		}

		public void Reset_string_field()
		{
			GDEDataManager.ResetToDefault(_key, string_fieldKey);
			GDEDataManager.Get(_key, out var data);
			data.TryGetString(string_fieldKey, out _string_field);
		}

		public void Reset_vector2_field()
		{
			GDEDataManager.ResetToDefault(_key, vector2_fieldKey);
			GDEDataManager.Get(_key, out var data);
			data.TryGetVector2(vector2_fieldKey, out _vector2_field);
		}

		public void Reset_vector3_field()
		{
			GDEDataManager.ResetToDefault(_key, vector3_fieldKey);
			GDEDataManager.Get(_key, out var data);
			data.TryGetVector3(vector3_fieldKey, out _vector3_field);
		}

		public void Reset_vector4_field()
		{
			GDEDataManager.ResetToDefault(_key, vector4_fieldKey);
			GDEDataManager.Get(_key, out var data);
			data.TryGetVector4(vector4_fieldKey, out _vector4_field);
		}

		public void Reset_color_field()
		{
			GDEDataManager.ResetToDefault(_key, color_fieldKey);
			GDEDataManager.Get(_key, out var data);
			data.TryGetColor(color_fieldKey, out _color_field);
		}

		public void Reset_custom_field()
		{
			GDEDataManager.ResetToDefault(_key, custom_fieldKey);
			GDEDataManager.Get(_key, out var data);
			data.TryGetString(custom_fieldKey, out var value);
			GDEDataManager.DataDictionary.TryGetCustom<string, object, GDESetCustomData>(value, out _custom_field);
			custom_field = GDEDataManager.GetCustom(_key + "_" + custom_fieldKey, _custom_field);
			custom_field.ResetAll();
		}

		public void ResetAll()
		{
			GDEDataManager.ResetToDefault(_key, bool_fieldKey);
			GDEDataManager.ResetToDefault(_key, int_fieldKey);
			GDEDataManager.ResetToDefault(_key, float_fieldKey);
			GDEDataManager.ResetToDefault(_key, string_fieldKey);
			GDEDataManager.ResetToDefault(_key, vector2_fieldKey);
			GDEDataManager.ResetToDefault(_key, vector3_fieldKey);
			GDEDataManager.ResetToDefault(_key, vector4_fieldKey);
			GDEDataManager.ResetToDefault(_key, color_fieldKey);
			GDEDataManager.ResetToDefault(_key, custom_fieldKey);
			Reset_custom_field();
			GDEDataManager.Get(_key, out var data);
			LoadFromDict(_key, data);
		}
	}
}