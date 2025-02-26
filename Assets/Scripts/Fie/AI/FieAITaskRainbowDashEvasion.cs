using Fie.Object;
using Fie.Ponies.RainbowDash;
using UnityEngine;

namespace Fie.AI
{
	public class FieAITaskRainbowDashEvasion : FieAITaskBase
	{
		private enum StepState
		{
			STATE_PREPARE,
			STATE_STEP
		}

		private const float ATTACK_DISTANCE = 15f;

		private bool _isEndState;

		private StepState _stepState;

		public override void Initialize(FieAITaskController manager)
		{
			_isEndState = false;
			_stepState = StepState.STATE_PREPARE;
		}

		public override bool Task(FieAITaskController manager)
		{
			if (manager.ownerCharacter.groundState != 0)
			{
				return true;
			}
			switch (_stepState)
			{
			case StepState.STATE_PREPARE:
			{
				Vector3 directionalVec = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
				manager.ownerCharacter.RequestToChangeState<FieStateMachineRainbowDashEvasion>(directionalVec, 1f, FieGameCharacter.StateMachineType.Base);
				FieStateMachineInterface currentStateMachine = manager.ownerCharacter.getStateMachine().getCurrentStateMachine();
				if (currentStateMachine is FieStateMachineRainbowDashEvasion || currentStateMachine is FieStateMachineRainbowDashEvasionBack || currentStateMachine is FieStateMachineRainbowDashEvasionFront || currentStateMachine is FieStateMachineRainbowDashEvasionUp || currentStateMachine is FieStateMachineRainbowDashEvasionDown)
				{
					currentStateMachine.stateChangeEvent += delegate
					{
						_isEndState = true;
					};
					_stepState = StepState.STATE_STEP;
				}
				else
				{
					_isEndState = true;
				}
				break;
			}
			case StepState.STATE_STEP:
				if (_isEndState)
				{
					return true;
				}
				break;
			}
			return false;
		}
	}
}
