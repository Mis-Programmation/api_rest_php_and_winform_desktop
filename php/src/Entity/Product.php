<?php

declare(strict_types=1);

namespace App\Entity;


use ApiPlatform\Core\Annotation\ApiResource;
use DateTimeInterface;
use Doctrine\ORM\Mapping as ORM;
use Doctrine\ORM\Mapping\Column;
use Doctrine\ORM\Mapping\Entity;
use Doctrine\ORM\Mapping\Table;
use Symfony\Component\Validator\Constraints as Assert;
use Symfony\Component\Serializer\Annotation\Groups;


#[
    ApiResource(

        collectionOperations: [
            "GET" => ['normalization_context' => ['groups' => 'read:categories'] ],
            "POST"
        ],
        itemOperations: [
            'GET',
            "PUT",
            "DELETE"
        ]
    )
]

/**
 * @Table()
 * @Entity()
 */
class Product
{
    use IdTrait;
    use TimeTrait;

    #[Assert\NotBlank]
    #[ Groups(["read:categories"]) ]
    /**
     * @Column(type="string",length=80,nullable=false)
     */
    private ?string $libelle = null;

    #[Assert\NotBlank]
    #[ Groups(["read:categories"]) ]
    /**
     * @Column(type="string",length=80,nullable=false)
     */
    private ?string $designation = null;

    #[ Assert\PositiveOrZero, Assert\NotNull]
    #[ Groups(["read:categories"]) ]
    /**
     * @Column(type="float",nullable=false)
     */
    private ?float $pu = null;

    #[ Groups(["read:categories"]) ]
    /**
     * @Column(type="datetime",nullable=false)
     */
    private DateTimeInterface $datePeremption;

    #[ Groups(["read:categories"]) ]
    /**
     * @var Categories
     * @ORM\ManyToOne(targetEntity="Categories",inversedBy="products")
     */
    private Categories $category;

    /**
     * @return string|null
     */
    public function getLibelle(): ?string
    {
        return $this->libelle;
    }

    /**
     * @param string|null $libelle
     * @return Product
     */
    public function setLibelle(?string $libelle): Product
    {
        $this->libelle = $libelle;
        return $this;
    }

    /**
     * @return string|null
     */
    public function getDesignation(): ?string
    {
        return $this->designation;
    }

    /**
     * @param string|null $designation
     * @return Product
     */
    public function setDesignation(?string $designation): Product
    {
        $this->designation = $designation;
        return $this;
    }

    /**
     * @return float|null
     */
    public function getPu(): ?float
    {
        return $this->pu;
    }

    /**
     * @param float|null $pu
     * @return Product
     */
    public function setPu(?float $pu): Product
    {
        $this->pu = $pu;
        return $this;
    }

    /**
     * @return DateTimeInterface
     */
    public function getDatePeremption(): DateTimeInterface
    {
        return $this->datePeremption;
    }

    /**
     * @param DateTimeInterface $datePeremption
     * @return Product
     */
    public function setDatePeremption(DateTimeInterface $datePeremption): Product
    {
        $this->datePeremption = $datePeremption;
        return $this;
    }

    /**
     * @return Categories
     */
    public function getCategory(): Categories
    {
        return $this->category;
    }

    /**
     * @param Categories $category
     */
    public function setCategory(Categories $category): void
    {
        $this->category = $category;
    }






}