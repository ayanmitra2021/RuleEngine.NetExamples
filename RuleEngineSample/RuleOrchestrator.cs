// See https://aka.ms/new-console-template for more information
using RuleEngineSample;

//RuleEvaluationService service0 = new RuleEvaluationService(RuleLibrary.CalculationExample);
//service0.EvaluateRule();


//RuleEvaluationService service1 = new RuleEvaluationService(RuleLibrary.DiscountRule);
//service1.EvaluateRule();


//RuleEvaluationService service2 = new RuleEvaluationService(RuleLibrary.ElgibilityRule);
//service2.EvaluateRule();


//RuleEvaluationService service3 = new RuleEvaluationService(RuleLibrary.ElgibilityPlusRule);
//service3.EvaluateRule();


//RuleEvaluationService service4 = new RuleEvaluationService(RuleLibrary.EligibilityChain);
//service4.EvaluateRuleWithActionFlow("GeneralEligibility");

//RuleEvaluationService service5 = new RuleEvaluationService(RuleLibrary.RuleWithAction);
//service5.EvaluateRuleWithActionFlow("ComplexRuleWithAction");

//RuleEvaluationService service7 = new RuleEvaluationService(RuleLibrary.udv_LTA_Salary);
//service7.EvaluateRuleWithActionFlow("LTA_Salary_Extra_Amount_Is_Null");

//RuleEvaluationService service8 = new RuleEvaluationService(RuleLibrary.Pension);
//service8.EvaluateRule();

//RuleEvaluationService service9 = new RuleEvaluationService(RuleLibrary.udv_LTA_SalaryV2);
//service9.EvaluateRule();

//RuleEvaluationService service10 = new RuleEvaluationService(RuleLibrary.EligibilityIIf);
//service10.EvaluateRule();

RuleEvaluationService service11 = new RuleEvaluationService(RuleLibrary.AndAlsoCheck);
service11.EvaluateRule();


////Sample rule
//RuleEvaluator.ExecuteDiscount();

////Eligiblity
//RuleEvaluator.ExecuteEligibility();

////Eligiblity Plus
//RuleEvaluator.ExecuteEligibilityPlus();

////Chaining rule
//RuleEvaluator.ExecuteEligibilityChain();

////Rule with actions
//RuleEvaluator.ExecuteRuleWithAction();

//Console.WriteLine("ABCD".Any(x => x == 'A'));
//Console.WriteLine((new List<string>() { "A", "A2", "B", "C" }).Contains("A2"));
//Math.Max()

