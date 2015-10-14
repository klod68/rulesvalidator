Description
===========
//Test only
This is a simple rules interpreter using a Command pattern component. 
The actual implementation use an XML file to store the rules and then 
check them when the Rulemanager.Validate() method is called.

The rules are expressed as constraints which represents evaluations 
of domain object properties against equal values, a set or range of options 
and other comparisons (more or equal, less or equal, etc.) The component 
supports .NET data types for properties and values.

Although the rules map source is implemented as an XML file, 
it could be implemented by any valid source (database or other any document type format) 
subclassing the RuleMap base class.

Below is a brief description of main interfaces:
ConstraintBase class. Abstract class that represent an expression of a comparison 
	for check in a rule. Any rule can have a set of constraints.
RuleBase class. Abstract class representing a rule. A rule have collection of constraints.
RuleMap class. Abstract class representing the map that links object properties and rules to be evaluated.
RulesManagerBase class. Abstract class for the command pattern implementation of the rule validator. 
	Its main method is Validate(), that receives the rule name to be checked and a set of objects 
	that contains the values to be revised, based on mapping rules.
RulesRepository class. Abstract class that contains all rules.

Future development
==================
Future developments are hoping to increase the support to other data sources for rules. 
Actually there's only support for a XML file rules source. I hope the next implementations 
support rules in databases and other text files alternatives.

The next improvement be in the direction of a callback function after the rule validation. 
That is to configure the rule manager to execute a pre-defined function once the validation 
delivers true or false. Then the project could be considered as real rule-engine.

History Notes
==============
-----------------
20140529
Change local repository location.
XML node comments check bug corrected.

20140528
In the production XML, please delete the comments nodes. 
In the current implementation there's a bug reading the comments as a significant node.
It will be corrected as soon as possible.