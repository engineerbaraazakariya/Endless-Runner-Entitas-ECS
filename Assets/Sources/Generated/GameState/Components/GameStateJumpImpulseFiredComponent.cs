//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity jumpImpulseFiredEntity { get { return GetGroup(GameStateMatcher.JumpImpulseFired).GetSingleEntity(); } }

    public bool isJumpImpulseFired {
        get { return jumpImpulseFiredEntity != null; }
        set {
            var entity = jumpImpulseFiredEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isJumpImpulseFired = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    static readonly JumpImpulseFiredComponent jumpImpulseFiredComponent = new JumpImpulseFiredComponent();

    public bool isJumpImpulseFired {
        get { return HasComponent(GameStateComponentsLookup.JumpImpulseFired); }
        set {
            if (value != isJumpImpulseFired) {
                var index = GameStateComponentsLookup.JumpImpulseFired;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : jumpImpulseFiredComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherJumpImpulseFired;

    public static Entitas.IMatcher<GameStateEntity> JumpImpulseFired {
        get {
            if (_matcherJumpImpulseFired == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.JumpImpulseFired);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherJumpImpulseFired = matcher;
            }

            return _matcherJumpImpulseFired;
        }
    }
}
