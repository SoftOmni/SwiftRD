using System;

namespace ReSharperPlugin.Swift.Technology.RelativePositions;

public class RelativePositioning
{
    private int _distance;
    
    public RelativePosition RelativePosition { get; private set; }

    public int Distance
    {
        get => _distance;
        set
        {
            if (RelativePosition is RelativePosition.At)
            {
                if (value != 0)
                {
                    throw new ArgumentException(
                        "Cannot set a relative positioning to be at a distance from the target greater than 0 " +
                        $"when the relative position is at (tried to set {value}", nameof(value));
                }

                _distance = 0;
                return;
            }

            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    "Cannot set a relative positioning to be at a distance from the target be a negative number.\n" +
                    $"Got {value}");
            }

            if (value == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    "Cannot set a relative positioning to be at a distance from the target be 0. Use at positioning.\n" +
                    $"The value you provided was {value}");
            }

            _distance = value;
        }
    }
    
    public object? Target { get; }

    private RelativePositioning(RelativePosition relativePosition, int distance, object? target = null)
    {
        RelativePosition = relativePosition;
        Distance = distance;
        Target = target;
    }

    public bool HasTargetSet => Target is not null;

    public bool TargetIsNotSet => Target is null;

    public static RelativePositioning NewAt(object? target = null)
    {
        return new RelativePositioning(RelativePosition.At, 0, target);
    }

    public static RelativePositioning NewBefore(int distance, object? target = null)
    {
        if (distance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(distance), "Cannot create a relative positioning (before relative positioning) " +
                                                                    $"from a negative value. You passed in {distance}");
        }

        if (distance == 0)
        {
            throw new ArgumentOutOfRangeException(nameof(distance), "Cannot create a before relative positioning " +
                                                                    $"from a 0 value");
        }
        
        return new RelativePositioning(RelativePosition.Before, distance, target);
    }
    
    public static RelativePositioning NewAfter(int distance, object? target = null)
    {
        if (distance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(distance), "Cannot create a relative positioning (after relative positioning) " +
                                                                    $"from a negative value. You passed in {distance}");
        }

        if (distance == 0)
        {
            throw new ArgumentOutOfRangeException(nameof(distance), "Cannot create a after relative positioning " +
                                                                    $"from a 0 value");
        }
        
        return new RelativePositioning(RelativePosition.After, distance, target);
    }

    public void MakeAt()
    {
        RelativePosition = RelativePosition.At;
        _distance = 0;
    }

    public void MakeBefore(int distance)
    {
        if (distance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(distance), "Cannot make a relative positioning before a distance " +
                                                                    $"from a negative value. You passed in {distance}.\n" +
                                                                    $"The relative positioning in question is {ToString()}");
        }

        if (distance == 0)
        {
            throw new ArgumentOutOfRangeException(nameof(distance), "Cannot make a relative positioning before a distance " +
                                                                    "from a 0 value.\n" +
                                                                    $"The relative positioning in question is {ToString()}");
        }

        _distance = distance;
        RelativePosition = RelativePosition.Before;
    }

    public void MakeAfter(int distance)
    {
        if (distance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(distance), "Cannot make a relative positioning after a distance " +
                                                                    $"from a negative value. You passed in {distance}.\n" +
                                                                    $"The relative positioning in question is {ToString()}");
        }

        if (distance == 0)
        {
            throw new ArgumentOutOfRangeException(nameof(distance), "Cannot make a relative positioning after a distance " +
                                                                    "from a 0 value.\n" +
                                                                    $"The relative positioning in question is {ToString()}");
        }

        _distance = distance;
        RelativePosition = RelativePosition.After;
    }
}