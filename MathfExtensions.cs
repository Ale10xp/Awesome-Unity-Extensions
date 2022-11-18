using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathfExtensions {

	

	public static float Lerp(float what, float newWhat, float smoothTime){

		//atribuição
		float currentWhat, nextWhat;
        currentWhat = what;
        nextWhat = currentWhat;

        what = newWhat;

        nextWhat = what;

        if (currentWhat != nextWhat)
        {

            what = Mathf.Lerp(currentWhat, nextWhat, smoothTime);

            currentWhat = nextWhat;
        }

		return what;

	}


	public static float LerpAngle(float what, float newWhat, float smoothTime){

		//atribuição
		float currentWhat, nextWhat;
        currentWhat = what;
        nextWhat = currentWhat;

        what = newWhat;

        nextWhat = what;

        if (currentWhat != nextWhat)
        {

            what = Mathf.LerpAngle(currentWhat, nextWhat, smoothTime);

            currentWhat = nextWhat;
        }

		return what;

	}

	public static Vector3 Vector3Lerp(Vector3 what, Vector3 newWhat, float smoothTime){

		//atribuição
		Vector3 currentWhat, nextWhat;
        currentWhat = what;
        nextWhat = currentWhat;

        what = new Vector3(newWhat.x,newWhat.y, newWhat.z);

        nextWhat = what;

        if (currentWhat.x != nextWhat.x)
        {

            what.x = Mathf.Lerp(currentWhat.x, nextWhat.x, smoothTime);

            currentWhat.x = nextWhat.x;
        }

		if (currentWhat.y != nextWhat.y)
        {

            what.y = Mathf.Lerp(currentWhat.y, nextWhat.y, smoothTime);

            currentWhat.y = nextWhat.y;
        }

		if (currentWhat.z != nextWhat.z)
        {

            what.z = Mathf.Lerp(currentWhat.z, nextWhat.z, smoothTime);

            currentWhat.z = nextWhat.z;
        }

		return what;
		

	}


	public static Vector3 Vector2Lerp(Vector2 what, Vector2 newWhat, float smoothTime){

		//atribuição
		Vector2 currentWhat, nextWhat;
        currentWhat = what;
        nextWhat = currentWhat;

        what = new Vector2(newWhat.x,newWhat.y);

        nextWhat = what;

        if (currentWhat.x != nextWhat.x)
        {

            what.x = Mathf.Lerp(currentWhat.x, nextWhat.x, smoothTime);

            currentWhat.x = nextWhat.x;
        }

		if (currentWhat.y != nextWhat.y)
        {

            what.y = Mathf.Lerp(currentWhat.y, nextWhat.y, smoothTime);

            currentWhat.y = nextWhat.y;
        }


		return what;
		

	}

	public static Vector2 LerpAngle(this Vector2 what, Vector2 newWhat, float smoothTime){

		//atribuição
		Vector2 currentWhat, nextWhat;
        currentWhat = what;
        nextWhat = currentWhat;

        what = new Vector2(newWhat.x,newWhat.y);

        nextWhat = what;

        if (currentWhat.x != nextWhat.x)
        {

            what.x = Mathf.LerpAngle(currentWhat.x, nextWhat.x, smoothTime);

            currentWhat.x = nextWhat.x;
        }

		if (currentWhat.y != nextWhat.y)
        {

            what.y = Mathf.LerpAngle(currentWhat.y, nextWhat.y, smoothTime);

            currentWhat.y = nextWhat.y;
        }


		return what;
		

	}

	public static Vector3 Vector3LerpToAngle(this Vector3 what, Vector3 newWhat, float smoothTime){

		//atribuição
		Vector3 currentWhat, nextWhat;
        currentWhat = what;
        nextWhat = currentWhat;

        what = new Vector3(newWhat.x,newWhat.y,newWhat.z);

        nextWhat = what;

        if (currentWhat.x != nextWhat.x)
        {

            what.x = Mathf.LerpAngle(currentWhat.x, nextWhat.x, smoothTime);

            currentWhat.x = nextWhat.x;
        }

		if (currentWhat.y != nextWhat.y)
        {

            what.y = Mathf.LerpAngle(currentWhat.y, nextWhat.y, smoothTime);

            currentWhat.y = nextWhat.y;
        }

		if (currentWhat.z != nextWhat.z)
        {

            what.z = Mathf.LerpAngle(currentWhat.z, nextWhat.z, smoothTime);

            currentWhat.z = nextWhat.z;
        }

		return what;
		

	}

    public static Vector3 Vector3LerpAngle(Vector3 what, Vector3 newWhat, float smoothTime){

		//atribuição
		Vector3 currentWhat, nextWhat;
        currentWhat = what;
        nextWhat = currentWhat;

        what = new Vector3(newWhat.x,newWhat.y,newWhat.z);

        nextWhat = what;

        if (currentWhat.x != nextWhat.x)
        {

            what.x = Mathf.LerpAngle(currentWhat.x, nextWhat.x, smoothTime);

            currentWhat.x = nextWhat.x;
        }

		if (currentWhat.y != nextWhat.y)
        {

            what.y = Mathf.LerpAngle(currentWhat.y, nextWhat.y, smoothTime);

            currentWhat.y = nextWhat.y;
        }

		if (currentWhat.z != nextWhat.z)
        {

            what.z = Mathf.LerpAngle(currentWhat.z, nextWhat.z, smoothTime);

            currentWhat.z = nextWhat.z;
        }

		return what;
		

	}

    //working version 0.2 [30/07/21]
    public static Color MapColor(Color colorA, Color colorB, Color colorC, float x, float min, float max)
    {

        Color a_to_b = MapColor(colorA, colorB, x, min, (max-min)/2);
        Color b_to_c = MapColor(colorB, colorC, x, (max-min)/2, max);
        Color actualColor;

/*
#region test
        float initial_r, initial_g, initial_b, initial_a;
        float midle_r, midle_g, midle_b, midle_a;

        float final_r, final_g, final_b, final_a;

        float actual_r, actual_g, actual_b, actual_a;

        initial_r = colorA.r;
        initial_g = colorA.g;
        initial_b = colorA.b;
        initial_a = colorA.a;

        midle_r = colorB.r;
        midle_g = colorB.g;
        midle_b = colorB.b;
        midle_a = colorB.a;
        
        final_r = colorC.r;
        final_g = colorC.g;
        final_b = colorC.b;
        final_a = colorC.a;

        float total = (max - min);

        if(x <= max/2)
        {

            actual_r = Map(x, min, total/2, initial_r, midle_r);        
            actual_g = Map(x, min, total/2, initial_g, midle_g);
            actual_b = Map(x, min, total/2, initial_b, midle_b);
            actual_a = Map(x, min, total/2, initial_a, midle_a);

        }

        else
        {
            actual_r = Map(x, total/2, max, midle_r, final_r);        
            actual_g = Map(x, total/2, max, midle_g, final_g);
            actual_b = Map(x, total/2, max, midle_b, final_b);
            actual_a = Map(x, total/2, max, midle_a, final_a);
        }

        // green = RGBA is (0, 1, 0, 1).
        // red =  RGBA is(1, 0, 0, 1).

#endregion
*/

        if(x <= ((max-min)/2) )
        {
            actualColor = a_to_b;
        }
        else
        {
            actualColor = b_to_c;
        }


        return actualColor;

    }

/*
     public static Color MapColor(Color[] arrColors, float x, float min, float max)
    {

        float actual_r, actual_g, actual_b, actual_a;


        //value proportional a color

        float total = (max - min);


        for (int i = 0; i < arrColors.Length; i++)
        {

            
        float[] initial_r;
        float[] initial_g;
        float[] initial_b;
        float[] initial_a;

        float[] final_r;
        float[] final_g;
        float[] final_b;
        float[] final_a;
        
            initial_r[i] = arrColors[i].r;
            initial_g[i] = arrColors[i].g;
            initial_b[i] = arrColors[i].b;
            initial_a[i] = arrColors[i].a;


            final_r[i+1] = arrColors[i+1].r;
            final_g[i+1] = arrColors[i+1].g;
            final_b[i+1] = arrColors[i+1].b;
            final_a[i+1] = arrColors[i+1].a;


            if(arrColors.Length == 2){

                actual_r = Map(x, min, max, initial_r[i], final_r[i+1]);
                actual_g = Map(x, min, max, initial_g[i], final_g[i+1]);
                actual_b = Map(x, min, max, initial_b[i], final_b[i+1]);
                actual_a = Map(x, min, max, initial_a[i], final_a[i+1]);
                
            }

            else
            {
                
                if(x <= (total/arrColors.Length) ){

                    actual_r = Map(x, min, total/arrColors.Length, initial_r[i], final_r[i+1]);
                    actual_g = Map(x, min, total/arrColors.Length, initial_g[i], final_g[i+1]);
                    actual_b = Map(x, min, total/arrColors.Length, initial_b[i], final_b[i+1]);
                    actual_a = Map(x, min, total/arrColors.Length, initial_a[i], final_a[i+1]);

                }
                else
                {

                    actual_r = Map(x, total/arrColors.Length, max, initial_r[i], final_r[i+1]);
                    actual_g = Map(x, total/arrColors.Length, max, initial_g[i], final_g[i+1]);
                    actual_b = Map(x, total/arrColors.Length, max, initial_b[i], final_b[i+1]);
                    actual_a = Map(x, total/arrColors.Length, max, initial_a[i], final_a[i+1]);


                }


            }






        }

        Color actualColor = new Color(actual_r, actual_g, actual_b, actual_a);

        return actualColor;

    }
*/
    
    public static Color MapColor(Color[] colors, float x, float min, float max){

        Color actualColor = Color.green;
 
            //colors.Length if 2 colors = 2
            //colors.Length if 3 colors = 3
            //colors.Length if 4 colors = 4

/*
            if (colors.Length %2 == 0){
                
                for (int i = 0; i < colors.Length-3; i++)
                {

                    if(x <= ( (max-min) / (colors.Length-1) ) )
                    {
                        actualColor = MapColor(colors[i], colors[i+1], x, min, (max-min)/(colors.Length-1) );         
                    }
                    else
                    {
                        actualColor = MapColor(colors[i+1], colors[i+2], x, (max-min)/(colors.Length-1), max);
                    }
                    
                
                }

            }

            else
            {
                if(x <= ( (max-min) / (colors.Length-1) ) )
                {
                    actualColor = MapColor(colors[colors.Length-colors.Length], colors[colors.Length-colors.Length+1], x, min, (max-min)/(colors.Length-1) );         
                }
                else
                {
                    actualColor = MapColor(colors[colors.Length-colors.Length+1], colors[colors.Length-colors.Length+2], x, (max-min)/(colors.Length-1), max);
                }

            }

*/

            if(x <= ( (max-min) / (colors.Length-1) ) )
                {
                    actualColor = MapColor(colors[colors.Length-colors.Length], colors[colors.Length-colors.Length+1], x, min, (max-min)/(colors.Length-1) );         
                }
                else
                {
                    actualColor = MapColor(colors[colors.Length-colors.Length+1], colors[colors.Length-colors.Length+2], x, (max-min)/(colors.Length-1), max);
                }


        return actualColor;

    }

    //working version 0.3 [01/08/21]
    public static Color MapColor(Color colorA, Color colorB, float x, float min, float max)
    {
        Color actualColor = new Color(
            Map(x, min, max, colorA.r, colorB.r),
            Map(x, min, max, colorA.g, colorB.g),
            Map(x, min, max, colorA.b, colorB.b),
            Map(x, min, max, colorA.a, colorB.a));

        return actualColor;

    }




    //working version 0.2 [30/07/21]
    public static Quaternion MapAngle(Quaternion quaternionA, Quaternion quaternionB, float x, float min, float max)
    {
        
            Quaternion initialQuaternion = quaternionA;
            Quaternion finalQuaternion = quaternionB;

            float actualX, actualY, actualZ, actualW;

            actualX = Map(x, min, max, initialQuaternion.x, finalQuaternion.x);
            actualY = Map(x, min, max, initialQuaternion.y, finalQuaternion.y);
            actualZ = Map(x, min, max, initialQuaternion.z, finalQuaternion.z);
            actualW = Map(x, min, max, initialQuaternion.w, finalQuaternion.w);

            Quaternion actualQuaternion = new Quaternion(actualX, actualY, actualZ, actualW);

            return actualQuaternion;

    }

    public static Vector3 MapAngle(Vector3 rotationA, Vector3 rotationB, float x, float min, float max)
    {
        return Vector3Map(rotationA, rotationB, x, min, max);
    }

    public static Vector3 Vector3Map(Vector3 rotationA, Vector3 rotationB, float x, float min, float max)
    {


        Vector3 actualRotation = new Vector3(
        Map(x, min, max, rotationA.x, rotationB.x),
        Map(x, min, max, rotationA.y, rotationB.y),
        Map(x, min, max, rotationA.z, rotationB.z));

        return actualRotation;

    }

    public static Color LerpColor(Color colorA, Color colorB, float smoothTime){

        Color initialColor = colorA;
        Color finalColor = colorB;


        float actual_r, actual_g, actual_b, actual_a;

        actual_r = Mathf.Lerp(initialColor.r, finalColor.r, smoothTime);
        actual_g = Mathf.Lerp(initialColor.g, finalColor.g, smoothTime);
        actual_b = Mathf.Lerp(initialColor.b, finalColor.b, smoothTime);
        actual_a = Mathf.Lerp(initialColor.a, finalColor.a, smoothTime);

        // green = RGBA is (0, 1, 0, 1).
        // red =  RGBA is(1, 0, 0, 1).

        Color actualColor = new Color(actual_r, actual_g, actual_b, actual_a);

        return actualColor;

    }

    public static Color LerpThisColorTo(this Color colorA, Color colorB, float smoothTime){

        Color initialColor = colorA;
        Color finalColor = colorB;


        float actual_r, actual_g, actual_b, actual_a;

        actual_r = Mathf.Lerp(initialColor.r, finalColor.r, smoothTime);
        actual_g = Mathf.Lerp(initialColor.g, finalColor.g, smoothTime);
        actual_b = Mathf.Lerp(initialColor.b, finalColor.b, smoothTime);
        actual_a = Mathf.Lerp(initialColor.a, finalColor.a, smoothTime);

        // green = RGBA is (0, 1, 0, 1).
        // red =  RGBA is(1, 0, 0, 1).

        Color actualColor = new Color(actual_r, actual_g, actual_b, actual_a);

        return actualColor;

    }

    /* //test arr v0.2
        public static float Map(float[] arr_X, float[] arr_in_min, float[] arr_in_max, float[] arr_out_min, float[] arr_out_max)
        {

            for (int i = 0; i < arr_X.Length; i++)
            {
                return (arr_X[i] - arr_in_min[i]) * (arr_out_max[i] - arr_out_min[i]) / (arr_in_max[i] - arr_in_min[i]) + arr_out_min[i];   
            }


        }
    */

    public static float[] Map(float x, float min, float max, float[] floatA, float[] floatB)
    {
        float[] valuesMapeds = null;

        if (floatA.Length == floatB.Length)
        {

            for (int i = 0; i < floatA.Length; i++)
            {
                valuesMapeds[i] = Map(x, min, max, floatA[i], floatB[i]);
            }

        }

        return valuesMapeds;

    }

    public static float Map(float x, float in_min, float in_max, float out_min, float out_max)
    {
        return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
    }


    //LerpMap 24/06/22 testing
    public static float LerpMap(float value, float min, float max, float new_min, float new_max, float smoothTime)
    {

        //mudança
        float x = Map(value, min, max, new_min, new_max);

        //lerp 
        return Lerp(value, x, smoothTime);

    }

    public static float MapLerp(float value, float min, float max, float new_min, float new_max, float smoothTime)
    {

        //mudança
        float x = Map(value, min, max, new_min, new_max);

        //lerp 
        return Lerp(value, x, smoothTime);

    }



    //ClampVector3 24/06/22 Working
    public static Vector3 ClampVector3(Vector3 value, Vector3 min, Vector3 max)
    {
        return new Vector3(Mathf.Clamp(value.x, min.x, max.x), Mathf.Clamp(value.y, min.y, max.y), Mathf.Clamp(value.z, min.z, max.z));

    }

    public static Vector3 ClampThisVector3(this Vector3 value, Vector3 min, Vector3 max)
    {
        return new Vector3(Mathf.Clamp(value.x, min.x, max.x), Mathf.Clamp(value.y, min.y, max.y), Mathf.Clamp(value.z, min.z, max.z));

    }

    public static Vector3 ClampThisVector3Axis(this Vector3 value, string AXIS, float min, float max)
    {
        Vector3 Value_new = value;

        if (AXIS == "x")
        {
            Value_new = new Vector3(Mathf.Clamp(value.x, min, max), Value_new.y, Value_new.z);

        }

        else if (AXIS == "y")
        {
            Value_new = new Vector3(Value_new.x, Mathf.Clamp(value.y, min, max), Value_new.z);
        }

        else if (AXIS == "z")
        {
            Value_new = new Vector3(Value_new.x, Value_new.y, Mathf.Clamp(value.z, min, max));
        }

        return Value_new;

    }

    public static Vector3 ClampVector3Axis(Vector3 value, string AXIS, float min, float max)
    {
        Vector3 Value_new = value;

        if (AXIS == "x")
        {
            Value_new = new Vector3(Mathf.Clamp(value.x, min, max), Value_new.y, Value_new.z);

        }

        else if (AXIS == "y")
        {
            Value_new = new Vector3(Value_new.x, Mathf.Clamp(value.y, min, max), Value_new.z);
        }

        else if (AXIS == "z")
        {
            Value_new = new Vector3(Value_new.x, Value_new.y, Mathf.Clamp(value.z, min, max));
        }

        return Value_new;

    }



}
