﻿namespace OSAE
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class OSAEObject
    {
        #region Properties

        private OSAEObjectManager objectManager = new OSAEObjectManager();

        private string _name;
        private string _description;
        private string _type;    
        private string _baseType;
        private string _address;             
        private string _container;
        private int _enabled;
        private string _lastUpd;
        private ObjectState _state;
        public List<ObjectProperty> Properties { get; set; }
        public List<string> Methods { get; set; }
        private OSAE osae = new OSAE("API");

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                objectManager.ObjectUpdate(_name, value, _description, _type, _address, _container, _enabled);
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                objectManager.ObjectUpdate(_name, _name, value, _type, _address, _container, _enabled);
            }
        }      

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                objectManager.ObjectUpdate(_name, _name, _description, value, _address, _container, _enabled);
            }
        }      

        public string BaseType
        {
            get
            {
                return _baseType;
            }
            set
            {
                _baseType = value;
            }
        }      

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                objectManager.ObjectUpdate(_name, _name, _description, _type, value, _container, _enabled);
            }
        }      

        public string Container
        {
            get
            {
                return _container;
            }
            set
            {
                _container = value;
                objectManager.ObjectUpdate(_name, _name, _description, _type, _address, value, _enabled);
            }
        }      
              
        public int Enabled  
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
                objectManager.ObjectUpdate(_name, _name, _description, _type, _address, _container, value);
            }
        }

        public ObjectState State
        {
            get
            {
                _state.Value = ObjectStateManager.GetObjectStateValue(_name).Value;
                return _state;
            }
            set
            {
                _state = value;
                ObjectStateManager.ObjectStateSet(_name, value.Value, "API");
            }
        }      

        public string LastUpd
        {
            get
            {
                return _lastUpd;
            }
            set
            {
                _lastUpd = value;
            }
        }
      
        
        #endregion

        public OSAEObject(string name, string description, string type, string address, string container, int enabled)
        {
            Name = name;
            Type = type;
            Address = address;
            Container = container;
            Enabled = enabled;
            Description = description;
            State = new ObjectState();
        }

        public OSAEObject()
        {
            State = new ObjectState();
        }

        public void Delete()
        {
            objectManager.ObjectDelete(Name);
        }

        public void SetState(string state)
        {
            ObjectStateManager.ObjectStateSet(Name, state, "API");
            State = ObjectStateManager.GetObjectStateValue(Name);
        }

        public void SetProperty(string prop, string value, string source)
        {
            ObjectPopertiesManager.ObjectPropertySet(Name, prop, value, source);
            foreach (ObjectProperty p in Properties)
            {
                if (p.Name == prop)
                {
                    p.Value = value;
                }
            }
        }

        public ObjectProperty Property(string prop)
        {
            foreach (ObjectProperty p in Properties)
            {
                if (p.Name == prop)
                    return p;
            }
            return null;
        }
    }
}
