<?php

namespace App\Entity;

use DateTimeInterface;
use Doctrine\ORM\Mapping as ORM;
use Doctrine\ORM\Mapping\Column;

trait TimeTrait
{


    /**
     * @Column(type="datetime_immutable",nullable=false)
     */
    private DateTimeInterface $createdAt;


    /**
     * @return DateTimeInterface
     */
    public function getCreatedAt(): \DateTimeInterface
    {
        return $this->createdAt;
    }

    /**
     * @param DateTimeInterface $createdAt
     * @return Categories|Product|TimeTrait
     */
    public function setCreatedAt(DateTimeInterface $createdAt): self
    {
        $this->createdAt = $createdAt;
        return $this;
    }

    public function __construct()
    {
        $this->createdAt = new \DateTimeImmutable();
    }


}