﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkShareMapper
{


    class PolicyRetrival
    {
        private string policyLocation = "Software\\Policies\\weatherlights.com\\NetworkDriveMapping";
        private RegistryKey policyStoreKey = null;


        public PolicyRetrival()
        {
            policyStoreKey = Registry.CurrentUser.OpenSubKey(policyLocation, false);
        }

        public string[] retrivePolicyNames()
        {
            RegistryKey myPolicyKey = Registry.CurrentUser.OpenSubKey(policyLocation + "\\Policies");
            return myPolicyKey.GetValueNames();
        }

        public NetworkDriveMappingPolicy GetPolicyByName(string name)
        {
            NetworkDriveMappingPolicy policy = null;
            using (RegistryKey policyPolicyKey = Registry.CurrentUser.OpenSubKey(policyLocation + "\\Policies"))
            {
                policy = new NetworkDriveMappingPolicy();
                if (policyPolicyKey.GetValueNames().Contains(name))
                {
                    string myPolicyValue = (string)policyPolicyKey.GetValue(name);
                    string[] myPolicyValueArray = myPolicyValue.Split(';');
                    if (myPolicyValueArray.Length > 1)
                    {
                        policy.driveLetter = myPolicyValueArray[0];
                        string myPathWithVariables = myPolicyValueArray[1];
                        policy.uncPath = Environment.ExpandEnvironmentVariables(myPathWithVariables);
                        if (myPolicyValueArray.Length > 3)
                        {
                            policy.Username = myPolicyValueArray[2];
                            policy.Password = myPolicyValueArray[3];
                        }
                    }
                }
            }
            return policy;
            
        }

        private bool TestRegistryKeyValue(string AttributeName)
        {
            if (policyStoreKey != null)
                if (policyStoreKey.GetValueNames().Contains(AttributeName))
                    return true;
            return false;
        }


        public bool isEnabled()
        {
            
            try
            {
                if (TestRegistryKeyValue("Enabled")) 
                {
                    int value = (int)policyStoreKey.GetValue("Enabled");
                    if (value > 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            } catch (Exception e)
            {
                return false;
            }
        }

        public bool isMapPersistent()
        {
            try
            {
                if (TestRegistryKeyValue("MapPersistent"))
                {
                    int value = (int)policyStoreKey.GetValue("MapPersistent");
                    if (value > 0)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public int getRefreshInterval()
        {
            try
            {
                if (TestRegistryKeyValue("RefreshInterval"))
                    return (int)policyStoreKey.GetValue("RefreshInterval");
                else
                    return 10000;
            }
            catch (Exception e)
            {
                return 10000;
            }
        }

        public int getRetryCount()
        {
            try
            {
                if (TestRegistryKeyValue("RetryCount"))
                    return (int)policyStoreKey.GetValue("RetryCount");
                else
                    return 15;
            }
            catch (Exception e)
            {
                return 15;
            }
        }

        public int getUpdateInterval()
        {
            try
            {
                if (TestRegistryKeyValue("UpdateInterval"))
                    return (int)policyStoreKey.GetValue("UpdateInterval");
                else
                    return 10800;
            }
            catch (Exception e)
            {
                return 10800;
            }
        }

        public bool isNetworkTestEnabled()
        {
            try
            {
                if (TestRegistryKeyValue("NetworkTestEnabled"))
                {
                    int value = (int)policyStoreKey.GetValue("NetworkTestEnabled");
                    if (value > 0)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }
            catch (Exception e)
            {
                return true;
            }
        }

    }
}
