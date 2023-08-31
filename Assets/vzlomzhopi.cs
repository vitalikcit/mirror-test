using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Net;
using UnityEngine.UI;
using TMPro;

public class vzlomzhopi : MonoBehaviour
{
    public Text ipnigga;
    public string entryIP;
    private void Start()
    {
        string localName = Dns.GetHostName();
        IPHostEntry entry = Dns.GetHostByName(localName);
        entryIP = entry.AddressList.Aggregate<IPAddress,string>("",(string a, IPAddress b) => { return a + " , " + b.MapToIPv4().ToString(); });
        Debug.Log("DNS HOST NAME: " + localName);
        Debug.Log("DNS IP LIST: " + entryIP);
    }
	void Update()
	{
        ipnigga.text = "Твой айпи " + entryIP;
	}
}