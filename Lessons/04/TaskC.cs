﻿using System;

namespace Lessons._04
{
    /// <summary>
    /// Write a code that demonstrates differences between 
    /// "throw;" and "throw exception;" in catch block.
    /// </summary>
    public class TaskC
    {
        public static void Run()
        {
            try
            {
                var s = int.Parse("Three");
            }
            catch (Exception exception)
            {
                
                //throw exception;
                throw;
            }
        }
    }
}