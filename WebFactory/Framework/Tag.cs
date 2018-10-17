using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;

using WebFactory.Framework.Components;



namespace WebFactory.Framework {
    public class Tag {
        public float width, height;
        public string Id;

        List<BaseComponent> Components = new List<BaseComponent>();

        public Tag(string id) {
            Id = id;
        }

        public string Render() {
            string res = $"<template id=\"{Id}\">";
            foreach (BaseComponent comp in Components) {
                res += comp.Render();
            }
            res += "</template>";
            return res;
        }

        public void AddComponent(BaseComponent comp) {
            comp.Init(this);
            Components.Add(comp);
        }
        public void AddComponents(IEnumerable<BaseComponent> comps) {
            foreach (BaseComponent comp in comps) {
                AddComponent(comp);
            }
        }

    }
}
