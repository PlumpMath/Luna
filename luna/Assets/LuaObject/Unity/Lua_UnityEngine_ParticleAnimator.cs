﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleAnimator : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator o;
			o=new UnityEngine.ParticleAnimator();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_doesAnimateColor(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			pushValue(l,self.doesAnimateColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_doesAnimateColor(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.doesAnimateColor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldRotationAxis(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			pushValue(l,self.worldRotationAxis);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldRotationAxis(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.worldRotationAxis=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localRotationAxis(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			pushValue(l,self.localRotationAxis);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localRotationAxis(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.localRotationAxis=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sizeGrow(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			pushValue(l,self.sizeGrow);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sizeGrow(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.sizeGrow=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndForce(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			pushValue(l,self.rndForce);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndForce(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.rndForce=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_force(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			pushValue(l,self.force);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_force(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.force=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_damping(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			pushValue(l,self.damping);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_damping(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.damping=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autodestruct(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			pushValue(l,self.autodestruct);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autodestruct(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autodestruct=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorAnimation(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			pushValue(l,self.colorAnimation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colorAnimation(IntPtr l) {
		try {
			UnityEngine.ParticleAnimator self=(UnityEngine.ParticleAnimator)checkSelf(l);
			UnityEngine.Color[] v;
			checkType(l,2,out v);
			self.colorAnimation=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleAnimator");
		addMember(l,"doesAnimateColor",get_doesAnimateColor,set_doesAnimateColor,true);
		addMember(l,"worldRotationAxis",get_worldRotationAxis,set_worldRotationAxis,true);
		addMember(l,"localRotationAxis",get_localRotationAxis,set_localRotationAxis,true);
		addMember(l,"sizeGrow",get_sizeGrow,set_sizeGrow,true);
		addMember(l,"rndForce",get_rndForce,set_rndForce,true);
		addMember(l,"force",get_force,set_force,true);
		addMember(l,"damping",get_damping,set_damping,true);
		addMember(l,"autodestruct",get_autodestruct,set_autodestruct,true);
		addMember(l,"colorAnimation",get_colorAnimation,set_colorAnimation,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleAnimator),typeof(UnityEngine.Component));
	}
}
