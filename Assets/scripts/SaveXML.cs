using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveXML : MonoBehaviour {

	// Use this for initialization
	void Start () {
		doc.Load (RenderingPath + "\\Assets\\USer_data.xml");
		XmlNode root = doc.FirstChild;
		XmlNodeList elemList = doc.GetElementByTagName ("name"); 
		for (int i = 0; i < elemList.count; i++) {
			
		}
	}

	public void AddNew() {
		XmlElement roots = doc.DocumentElement; 
		XmlElement x1 = doc.CreateElement ("user");
		XmlElement x2 = doc.CreateElement ("name");
		XmlElement x3 = doc.CreateElement ("hostname");
		XmlElement x4 = doc.CreateElement ("ipaddress");
		XmlElement x5 = doc.CreateElement ("started");
		XmlElement x6 = doc.CreateElement ("ended");
		XmlElement x7 = doc.CreateElement ("life_left");

	}
	
	// Update is called once per frame
	void Update () {
		if (save_now == true) {
			AddNew ();
			save_now = false; 
		}
	}
}
