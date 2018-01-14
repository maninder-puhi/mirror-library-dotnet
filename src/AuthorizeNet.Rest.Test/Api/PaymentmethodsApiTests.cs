/* 
 * Authorize.net REST API
 *
 * Authorize.net REST API
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using AuthorizeNet.Rest.Client;
using AuthorizeNet.Rest.Api;
using AuthorizeNet.Rest.Model;

namespace AuthorizeNet.Rest.Test
{
    /// <summary>
    ///  Class for testing PaymentmethodsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PaymentmethodsApiTests
    {
        private PaymentmethodsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PaymentmethodsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentmethodsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' PaymentmethodsApi
            Assert.IsInstanceOfType(typeof(PaymentmethodsApi), instance, "instance is a PaymentmethodsApi");
        }

        
        /// <summary>
        /// Test CreatePaymentMethod
        /// </summary>
        [Test]
        public void CreatePaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //CreatePaymentMethod createPaymentMethod = null;
            //string authorization = null;
            //var response = instance.CreatePaymentMethod(customerId, createPaymentMethod, authorization);
            //Assert.IsInstanceOf<PaymentMethod> (response, "response is PaymentMethod");
        }
        
        /// <summary>
        /// Test DeletePaymentmethod
        /// </summary>
        [Test]
        public void DeletePaymentmethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //string paymentMethodId = null;
            //string authorization = null;
            //instance.DeletePaymentmethod(customerId, paymentMethodId, authorization);
            
        }
        
        /// <summary>
        /// Test GetCustomerPaymentMethod
        /// </summary>
        [Test]
        public void GetCustomerPaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //string paymentMethodId = null;
            //string authorization = null;
            //var response = instance.GetCustomerPaymentMethod(customerId, paymentMethodId, authorization);
            //Assert.IsInstanceOf<PaymentMethod> (response, "response is PaymentMethod");
        }
        
        /// <summary>
        /// Test GetCustomerPaymentMethods
        /// </summary>
        [Test]
        public void GetCustomerPaymentMethodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //string authorization = null;
            //var response = instance.GetCustomerPaymentMethods(customerId, authorization);
            //Assert.IsInstanceOf<PaymentMethodCollection> (response, "response is PaymentMethodCollection");
        }
        
        /// <summary>
        /// Test UpdatePaymentMethod
        /// </summary>
        [Test]
        public void UpdatePaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerId = null;
            //string paymentMethodId = null;
            //CreatePaymentMethod createPaymentMethod = null;
            //string authorization = null;
            //var response = instance.UpdatePaymentMethod(customerId, paymentMethodId, createPaymentMethod, authorization);
            //Assert.IsInstanceOf<PaymentMethod> (response, "response is PaymentMethod");
        }
        
    }

}
