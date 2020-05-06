using System;
using UnityEngine;


namespace Singleton
{
    public sealed class Services
    {
        private static readonly object _lock = new object();
        
        #region Fields
        
        private static readonly Lazy<Services> _instance = 
            new Lazy<Services>(() => new Services());

        #endregion


        #region ClassLifeCycles

        private Services()
        {
            Initialize();
        }

        #endregion
        
        
        #region Properties

        //public static Services Instance => _instance.Value;
        public static Services Instance
        {
            
            get
            {
                lock (_lock)
                {
                    return _instance.Value; 
                }
            }
        }
        
        #endregion
        
        
        #region Methods
        
        private void Initialize()
        {
        }

        public void Test()
        {
            Debug.Log(nameof(Services));
        }
        
        #endregion
    }
}
