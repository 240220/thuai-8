namespace Thuai.Server.GameLogic;

public enum SkillName
{
    BLACK_OUT,
    SPEED_UP,
    FLASH,
    DESTROY,
    CONSTRUCT,
    TRAP,
    MISSILE,
    KAMUI
}

public class Skill
{
    public SkillName name;
    public int maxCooldown;
    public int currentCooldown;
    public int activeTime;
    public int currentActiveTime;

    public Skill(SkillName skillName)
    {
        name = skillName;
    }

    public void UpdateCoolDown()
    {
        if (currentCooldown > 0)
        {
            currentCooldown--;
        }
    }

    public void UpdateActiveTime()
    {
        if (currentActiveTime > 0)
        {
            currentActiveTime--;
        }
    }
    public virtual void UseSkill(Player player)
    {
        if (currentCooldown == 0)
        {
            currentCooldown = maxCooldown;
            currentActiveTime = activeTime;
        }
    }
}
