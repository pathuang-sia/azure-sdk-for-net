// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    internal class Samples_Devices
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<deviceId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<deviceId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                deviceDataModelId = "<deviceDataModelId>",
                integrationId = "<integrationId>",
                type = "<type>",
                hardwareId = "<hardwareId>",
                reportingIntervalInSeconds = 1234,
                parentDeviceId = "<parentDeviceId>",
                location = new
                {
                    latitude = 123.45,
                    longitude = 123.45,
                },
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<sensorPartnerId>", "<deviceId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("deviceDataModelId").ToString());
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("hardwareId").ToString());
            Console.WriteLine(result.GetProperty("reportingIntervalInSeconds").ToString());
            Console.WriteLine(result.GetProperty("parentDeviceId").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("latitude").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("longitude").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            RequestContent content = RequestContent.Create(new
            {
                deviceDataModelId = "<deviceDataModelId>",
                integrationId = "<integrationId>",
                type = "<type>",
                hardwareId = "<hardwareId>",
                reportingIntervalInSeconds = 1234,
                parentDeviceId = "<parentDeviceId>",
                location = new
                {
                    latitude = 123.45,
                    longitude = 123.45,
                },
                status = "<status>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<sensorPartnerId>", "<deviceId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("deviceDataModelId").ToString());
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("hardwareId").ToString());
            Console.WriteLine(result.GetProperty("reportingIntervalInSeconds").ToString());
            Console.WriteLine(result.GetProperty("parentDeviceId").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("latitude").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("longitude").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDevice()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetDevice("<sensorPartnerId>", "<deviceId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDevice_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetDeviceAsync("<sensorPartnerId>", "<deviceId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDevice_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetDevice("<sensorPartnerId>", "<deviceId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("deviceDataModelId").ToString());
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("hardwareId").ToString());
            Console.WriteLine(result.GetProperty("reportingIntervalInSeconds").ToString());
            Console.WriteLine(result.GetProperty("parentDeviceId").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("latitude").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("longitude").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDevice_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetDeviceAsync("<sensorPartnerId>", "<deviceId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("deviceDataModelId").ToString());
            Console.WriteLine(result.GetProperty("integrationId").ToString());
            Console.WriteLine(result.GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("hardwareId").ToString());
            Console.WriteLine(result.GetProperty("reportingIntervalInSeconds").ToString());
            Console.WriteLine(result.GetProperty("parentDeviceId").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("latitude").ToString());
            Console.WriteLine(result.GetProperty("location").GetProperty("longitude").ToString());
            Console.WriteLine(result.GetProperty("sensorPartnerId").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<deviceId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<deviceId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<sensorPartnerId>", "<deviceId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<sensorPartnerId>", "<deviceId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDevices()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetDevices("<sensorPartnerId>", null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDevices_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetDevicesAsync("<sensorPartnerId>", null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetDevices_AllParameters()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetDevices("<sensorPartnerId>", new List<string>()
{
"<parentDeviceIds>"
}, new List<string>()
{
"<deviceDataModelIds>"
}, new List<string>()
{
"<ids>"
}, new List<string>()
{
"<names>"
}, new List<string>()
{
"<propertyFilters>"
}, new List<string>()
{
"<statuses>"
}, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("deviceDataModelId").ToString());
                Console.WriteLine(result[0].GetProperty("integrationId").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareId").ToString());
                Console.WriteLine(result[0].GetProperty("reportingIntervalInSeconds").ToString());
                Console.WriteLine(result[0].GetProperty("parentDeviceId").ToString());
                Console.WriteLine(result[0].GetProperty("location").GetProperty("latitude").ToString());
                Console.WriteLine(result[0].GetProperty("location").GetProperty("longitude").ToString());
                Console.WriteLine(result[0].GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetDevices_AllParameters_Async()
        {
            TokenCredential credential = new DefaultAzureCredential();
            Devices client = new FarmBeatsClient(credential).GetDevicesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetDevicesAsync("<sensorPartnerId>", new List<string>()
{
"<parentDeviceIds>"
}, new List<string>()
{
"<deviceDataModelIds>"
}, new List<string>()
{
"<ids>"
}, new List<string>()
{
"<names>"
}, new List<string>()
{
"<propertyFilters>"
}, new List<string>()
{
"<statuses>"
}, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result[0].GetProperty("deviceDataModelId").ToString());
                Console.WriteLine(result[0].GetProperty("integrationId").ToString());
                Console.WriteLine(result[0].GetProperty("type").ToString());
                Console.WriteLine(result[0].GetProperty("hardwareId").ToString());
                Console.WriteLine(result[0].GetProperty("reportingIntervalInSeconds").ToString());
                Console.WriteLine(result[0].GetProperty("parentDeviceId").ToString());
                Console.WriteLine(result[0].GetProperty("location").GetProperty("latitude").ToString());
                Console.WriteLine(result[0].GetProperty("location").GetProperty("longitude").ToString());
                Console.WriteLine(result[0].GetProperty("sensorPartnerId").ToString());
                Console.WriteLine(result[0].GetProperty("id").ToString());
                Console.WriteLine(result[0].GetProperty("status").ToString());
                Console.WriteLine(result[0].GetProperty("createdDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result[0].GetProperty("eTag").ToString());
                Console.WriteLine(result[0].GetProperty("name").ToString());
                Console.WriteLine(result[0].GetProperty("description").ToString());
                Console.WriteLine(result[0].GetProperty("createdBy").ToString());
                Console.WriteLine(result[0].GetProperty("modifiedBy").ToString());
                Console.WriteLine(result[0].GetProperty("properties").GetProperty("<key>").ToString());
            }
        }
    }
}
