CALL osae_sp_object_type_add ('SQUEEZEBOX','Squeezebox Device','','',0,0,0,1);
CALL osae_sp_object_type_state_add ('ON','Playing','SQUEEZEBOX');
CALL osae_sp_object_type_state_add ('OFF','Stopped','SQUEEZEBOX');
CALL osae_sp_object_type_event_add ('ON','Playing','SQUEEZEBOX');
CALL osae_sp_object_type_event_add ('OFF','Stopped','SQUEEZEBOX');
CALL osae_sp_object_type_method_add ('PLAY','Play','SQUEEZEBOX','Item','','','');
CALL osae_sp_object_type_method_add ('STOP','Stop','SQUEEZEBOX','','','','');
CALL osae_sp_object_type_method_add ('NEXT','Next','SQUEEZEBOX','','','','');
CALL osae_sp_object_type_method_add ('PREV','Prev','SQUEEZEBOX','','','','');
CALL osae_sp_object_type_method_add ('SHOW','Display Message','SQUEEZEBOX','message','','','');
CALL osae_sp_object_type_method_add ('TTS','Text To Speech','SQUEEZEBOX','message','','','');
CALL osae_sp_object_type_method_add ('TTSLIST','Text To Speech From List','SQUEEZEBOX','object','property','','');
CALL osae_sp_object_type_method_add ('TTSLISTRAND','Text To Speech Random From List','SQUEEZEBOX','object','property','','');

CALL osae_sp_object_type_add ('SQUEEZEBOX SERVER','Squeezebox Server','','PLUGIN',1,1,0,1);
CALL osae_sp_object_type_state_add ('ON','Running','SQUEEZEBOX SERVER');
CALL osae_sp_object_type_state_add ('OFF','Stopped','SQUEEZEBOX SERVER');
CALL osae_sp_object_type_event_add ('ON','Started','SQUEEZEBOX SERVER');
CALL osae_sp_object_type_event_add ('OFF','Stopped','SQUEEZEBOX SERVER');
CALL osae_sp_object_type_method_add ('ON','Start','SQUEEZEBOX SERVER','','','','');
CALL osae_sp_object_type_method_add ('OFF','Stop','SQUEEZEBOX SERVER','','','','');
CALL osae_sp_object_type_property_add ('Server Address','String','','SQUEEZEBOX SERVER',0);
CALL osae_sp_object_type_property_add ('CLI Port','String','9090','SQUEEZEBOX SERVER',0);
CALL osae_sp_object_type_property_add ('TTS Save Path','String','','SQUEEZEBOX SERVER',0);
CALL osae_sp_object_type_property_add ('TTS Play Path','String','','SQUEEZEBOX SERVER',0);