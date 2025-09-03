using Newtonsoft.Json.Linq;
using Opc.UaFx;
using Opc.UaFx.Client;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOPCUA : MonoBehaviour
{
    public string serverUrl = "opc.tcp://localhost:4840";
    OpcClient client;
    public string d1,d2,d3,d4,d5,d6,d7,d8,d9,d10,d11,d12,d13;
    // Start is called before the first frame update
    void Start()
    {
        client = new OpcClient(serverUrl, new OpcSecurityPolicy(OpcSecurityMode.None) );
       
        client.Connect();
    
       client.SubscribeDataChange("ns=3;i=1011", (node, value) =>
        {
            d1 =value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1012", (node, value) =>
        {
            d2 = value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1013", (node, value) =>
        {
            d3 = value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1014", (node, value) =>
        {
            d4 = value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1015", (node, value) =>
        {
            d5 = value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1016", (node, value) =>
        {
            d6 = value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1017", (node, value) =>
        {
            d12 = value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1018", (node, value) =>
        {
            d7 = value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1019", (node, value) =>
        {
            d8 = value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1020", (node, value) =>
        {
            d9 = value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1021", (node, value) =>
        {
            d10 = value.Item.Value.ToString();
        });
        client.SubscribeDataChange("ns=3;i=1022", (node, value) =>
        {
            d11 = value.Item.Value.ToString();
        });
    }
    private void OnDisable()
    {
        client.Disconnect();
    }
    // Update is called once per frame
    void Update()
    {
        if (client != null)
        {
            var value = client.ReadNode("ns=3;i=1023");
            d13 = value.ToString();
            Debug.Log(d13);
        }
      
        
    }
}
