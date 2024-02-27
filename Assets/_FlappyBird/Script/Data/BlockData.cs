using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlockData", menuName = "Data/Block Data")]
public class BlockData : ScriptableObject
{
    public List<BlockSprite> listBlockSprite;
}

[Serializable]
public class BlockSprite
{
    public BlockType blockType;
    public SpriteInfos spriteinfos;
}

[Serializable]
public class SpriteInfos
{
    public List<Sprite> listSprite;
    public float maxHP;
}

public enum BlockType
{
    wood = 0,
    stone = 1,
    metal = 2,
}
